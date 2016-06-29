using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour
{
    public bool state;
    public GameObject[] neighbors;

    public void OnMouseDown()
    {
        ChangeState();
        foreach (GameObject neighbor in neighbors)
            neighbor.GetComponent<Element>().ChangeState();
    }

    public void ChangeState()
    {
        state = !state;
        if (state)
            GetComponentInChildren<Animator>().Play("On");
        else
            GetComponentInChildren<Animator>().Play("Off");
    }

}
