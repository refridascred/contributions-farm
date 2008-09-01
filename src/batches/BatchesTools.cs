using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardFactor = 85.58;
        public const long BurstMetric = 9716;
        public const long MaxMetric = 5239;
        public const long CacheMetric = 869;
        public const string IdleSize = "standard-v2";

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Retry,
            New,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Done,
            Idle,
        }
    }
}
