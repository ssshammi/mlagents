using UnityEngine;

public class ObstacleCourseSettings : MonoBehaviour
{
    [Header("Specific to ObstacleCourse")]
    public float agentRunSpeed;
    public float agentJumpHeight;
    //when a goal is scored the ground will use this material for a few seconds.
    public Material goalScoredMaterial;
    //when fail, the ground will use this material for a few seconds.
    public Material failMaterial;

    [HideInInspector]
    public float agentJumpVelocity = 777;
    [HideInInspector]
    public float agentJumpVelocityMaxChange = 10;

}
