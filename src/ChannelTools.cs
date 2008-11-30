using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitLevel = 8607;
        public const long DefaultWidth = 2329;
        public const string BaseSpan = "stable-v2";
        public const double CacheSize = 71.82;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
