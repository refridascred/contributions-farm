using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryScore = 1123;
        public const long CacheSize = 3764;
        public const double WindowMetric = 85.38;
    }
}
