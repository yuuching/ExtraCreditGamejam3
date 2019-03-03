using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10.0f;
    private float movement = 0f;

    public Animator animator;

    private Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        Debug.Log(Speed);
    }

    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");

        if (movement > 0.0f)
        {
            rb.velocity = new Vector2(movement * Speed, rb.velocity.y);
        }

        if (movement == 0f)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
           
        }

        else
        {
            rb.velocity = new Vector2(movement * Speed, rb.velocity.y);
        }

        animator.SetFloat("Speed", movement);

    }
}