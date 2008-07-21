using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseSpan = "alpha-1";
        public const double IdleQueue = 28.06;
        public const string BurstInterval = "alpha-v2";
        public const double BurstLevel = 97.82;

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetrySize = 78.58;
        public const string MaxInterval = "primary";
        public const long LimitBudget = 3602;
        public const long CacheTimeout = 3595;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardCount = 6712;
        public const long WindowMetric = 3442;
        public const double DefaultMetric = 47.16;
        public const long MaxMetric = 6454;
    }
}
