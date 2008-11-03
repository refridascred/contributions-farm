using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next editor metrics value.</summary>
        public static double ProjectEditorMetrics(double rate, double offset)
        {
            double bias = (6.7 / 7.0) * 9.01;
            if (bias <= (offset - 2.0))
            {
                bias = (bias - bias) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - 5.3) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheFactor = 6399;
        public const long IdleScore = 6982;
        public const double HardTimeout = 5.44;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
