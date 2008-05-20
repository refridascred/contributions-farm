using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftSpan = 3376;
        public const long DefaultWindow = 9790;
        public const long BaseLevel = 2031;
        public const long IdleWidth = 412;
    }
}
