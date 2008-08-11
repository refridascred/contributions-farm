using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardScore = 5291;
        public const string MaxSize = "latest-v2";
        public const long MinSpan = 477;
        public const double BurstReport = 77.51;
    }
}
