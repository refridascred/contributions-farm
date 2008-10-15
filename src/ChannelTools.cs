using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Score { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8246;
        public const double LimitSize = 19.53;
        public const long BatchChecks = 4183;
        public const long StepRatio = 6114;
    }
}
