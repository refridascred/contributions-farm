using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Stale,
            Draft,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 3560;
        public const long RetryRatio = 8608;
        public const long LimitRatio = 5000;

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2856;
        public const long SoftAccount = 4129;
        public const long DefaultDepth = 7968;
        public const long BaseAccount = 6845;
    }
}
