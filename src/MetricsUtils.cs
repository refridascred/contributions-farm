using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Failed,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "stable-v2";
        public const long BaseScore = 6097;
        public const long RetryWindow = 8608;
        public const string SoftBudget = "open-1";

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Dropped,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseRatio = 58.69;
        public const long DefaultMetric = 7817;
        public const long BurstWidth = 170;
        public const long BatchSize = 6823;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Active,
            Stale,
            Retry,
        }
    }
}
