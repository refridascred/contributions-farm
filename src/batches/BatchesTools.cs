using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepScore = 6.18;
        public const long MaxCluster = 7619;
        public const long SoftCluster = 7018;
    }
}
