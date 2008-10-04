using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            New,
            Locked,
        }
    }
}
