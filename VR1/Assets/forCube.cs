using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forCube : MonoBehaviour
{
    public GameObject objectCube;
    private bool isActive = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }




    public void tapOnButton()
    {
        if (isActive)
        {
            isActive = false;
            objectCube.SetActive(isActive);
        }
        else
        {
            isActive = true;
            objectCube.SetActive(isActive);
        }
    }
}