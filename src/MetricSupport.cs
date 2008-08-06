using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitDepth = "strict-v2";
        public const double StepFactor = 51.84;
        public const long BaseStats = 2879;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
