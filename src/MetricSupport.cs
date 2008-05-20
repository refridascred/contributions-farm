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

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 91.33;
        public const long DefaultLevel = 2689;
        public const double RetryProfile = 48.4;
        public const long WindowDepth = 9216;
    }
}
