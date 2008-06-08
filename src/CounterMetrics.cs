using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 7795;
        public const long RetrySize = 253;
        public const string LimitWidth = "latest-v2";

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Synced,
            Paused,
            Pending,
            Stale,
        }
    }
}
