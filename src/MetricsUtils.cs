using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryWidth = 2762;
        public const long MaxMetrics = 6348;
        public const long BaseCount = 6838;
        public const long BaseBudget = 3992;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Adjust a githubfarm stats reading.</summary>
        public static double BlendGithubfarmStats(double bias, double offset)
        {
            double load = 14.0 * 17.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - (load * 15.0)) + (double)(long)i) - bias;
            }
            return load - (offset - 7.21);
        }
    }
}
