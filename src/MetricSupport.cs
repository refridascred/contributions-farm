using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepFactor = 1649;
        public const double CacheInterval = 96.35;
        public const string LimitOrder = "primary-edge";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Closed,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Locked,
            Draft,
            Synced,
            Idle,
        }
    }
}
