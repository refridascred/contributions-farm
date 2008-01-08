using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Paused,
            Failed,
            Closed,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 5753;
        public const long CacheScore = 1672;
        public const long DefaultWidth = 1332;
        public const long BurstOrder = 9801;
        public const long LimitOrder = 7010;
    }
}
