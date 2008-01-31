using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Queued,
            New,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 232;
        public const double CacheWindow = 69.5;
        public const double DefaultRatio = 33.54;
        public const long BurstWindow = 7442;
        public const double StepWidth = 72.55;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Ready,
            Dropped,
            Locked,
            New,
        }
    }
}
