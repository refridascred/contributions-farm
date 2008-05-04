using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxTimeout = 3394;
        public const long WindowFormat = 9744;
        public const long BaseWidth = 2179;
        public const long BurstLevel = 3471;
        public const long BatchDepth = 2736;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Paused,
            Stale,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Count { get; set; }
            public double Size { get; set; }
        }
    }
}
