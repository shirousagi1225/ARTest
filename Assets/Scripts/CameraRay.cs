using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour
{
    public Animator leftCamAni;
    public Animator rightCamAni;

    private LayerMask layerMask = 1 << 6;
    private RaycastHit hit;

    private void FixedUpdate()
    {
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,2.0f, layerMask))
        {
            leftCamAni.SetBool("focus",true);
            rightCamAni.SetBool("focus",true);
        }
        else
        {
            leftCamAni.SetBool("focus", false);
            rightCamAni.SetBool("focus", false);
        }
    }
}
