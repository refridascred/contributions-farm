using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 6723;
        public const long IdleEntry = 9657;
        public const double MaxEntry = 18.83;
        public const long BurstEntry = 2953;
        public const long CacheRatio = 3426;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Dropped,
            Active,
            Retry,
            Queued,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            New,
            Retry,
        }
    }
}
