using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 5281;
        public const double MinOrder = 75.82;
        public const double CacheOrder = 42.36;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Queued,
            Done,
            Ready,
            Active,
        }
    }
}
