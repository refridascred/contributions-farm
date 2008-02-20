using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Synced,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1140;
        public const double DefaultCounter = 42.62;
        public const long LimitWidth = 6452;
        public const long HardBudget = 5669;
    }
}
