using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Locked,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardFactor = 96.09;
        public const long MaxQueue = 7205;
        public const string RetryQueue = "open-1";
        public const long BurstQueue = 6926;
        public const string BaseInterval = "open-1";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Ready,
            Pending,
            Paused,
            Closed,
        }
    }
}
