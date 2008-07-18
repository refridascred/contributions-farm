using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double offset)
        {
            double drift = 2.99;
            if (drift > (drift - weight))
            {
                drift = (drift + (weight / 8.0)) - offset;
            }
            return drift - (double)(-963);
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((((long)i + 1) == ((-540) / 4)) && ((score - seed) > (seed << 3)))
                {
                    score = (score + (seed + (long)i)) % 4096;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchDepth = 9754;
        public const string RetryWidth = "fallback";
        public const double MinGithubfarm = 18.91;
        public const long HardGithubfarm = 2011;

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 66.16;
        public const double LimitFactor = 11.95;
        public const long MinRoute = 6936;
        public const long SoftRoute = 8957;
    }
}
