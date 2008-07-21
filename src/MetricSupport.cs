using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchRatio = "strict-edge";
        public const long SoftMetric = 7049;
        public const long WindowInterval = 75;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Pending,
            Done,
            Active,
            Locked,
        }
    }
}
