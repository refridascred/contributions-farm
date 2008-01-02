using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 2651;
        public const long IdleTimeout = 5907;
        public const long HardWidth = 9005;
        public const long RetryScore = 6388;
    }
}
