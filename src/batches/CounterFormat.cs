using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            New,
            Stale,
            Retry,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Stale,
            Ready,
            Closed,
        }
    }
}
