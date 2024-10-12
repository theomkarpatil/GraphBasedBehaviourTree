// Developed by Sora
//
// Copyright(c) Sora Arts 2023-2024
//
// This script is covered by a Non-Disclosure Agreement (NDA) and is Confidential.
// Destroy the file immediately if you have not been explicitly granted access.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sora.AI.BehaviourTrees
{
    [CreateAssetMenu(fileName = "SampleBlackBoard", menuName = "Sora /BehaviourTree/SampleBlackBoard")]
    public class SampleBB : Blackboard
    {
        public float speed;
        public bool sprinting;
    }
}