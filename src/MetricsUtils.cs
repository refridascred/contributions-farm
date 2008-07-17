using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long TallyStreamOrderOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value <= (2.0 * 9.03))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
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

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
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
