using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleTimeout = 6612;
        public const long MinCounter = 8938;
        public const long MinInterval = 3309;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Active,
            Dropped,
            Paused,
            Draft,
        }
    }
}
