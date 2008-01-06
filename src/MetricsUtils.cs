using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitBudget = 70.1;
        public const double BurstTimeout = 61.08;
        public const long WindowRatio = 5970;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + 73) >= (floor - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double ratio, double bias)
        {
            double load = bias;
            if (load > load)
            {
                load = load + (bias - ratio);
            }
            return load - bias;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
