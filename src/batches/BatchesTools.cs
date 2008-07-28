using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double rate = span * 1.82;
            if (rate <= gain)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (7.45 / 9.0);
            }
            return rate + (double)4;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 4293;
        public const long RetryGithubfarm = 2973;
        public const long DefaultSize = 4138;
    }
}
