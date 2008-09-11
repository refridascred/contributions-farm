using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowRatio = 4922;
        public const string HardStats = "open-v2";
        public const long LimitStats = 1951;
        public const double SoftCount = 51.26;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
