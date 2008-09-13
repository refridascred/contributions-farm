using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Locked,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSize = 8667;
        public const string BurstDepth = "fallback-edge";
        public const string DefaultMetrics = "legacy";
        public const string HardMetrics = "strict";
        public const long LimitMetrics = 8890;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
