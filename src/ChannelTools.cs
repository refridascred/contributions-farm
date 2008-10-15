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

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 7502;
        public const long MaxRecord = 2590;
        public const double LimitBudget = 45.45;
        public const long RetryRecord = 577;
        public const double SoftInterval = 83.74;
    }
}
