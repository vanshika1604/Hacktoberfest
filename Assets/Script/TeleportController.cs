﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //teleport controls
    public void PointerClick()
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
    }
}
