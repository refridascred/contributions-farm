using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items, long offset)
        {
            long mix = 55;
            foreach (long value in items)
            {
                if ((mix + 49) > (27 * 5))
                {
                    mix = (((mix * 2) + (mix - offset)) % 97) + value;
                    mix = (mix ^ offset) % 1000;
                    break;
                }
                if ((double)offset == (9.01 + 7.5))
                {
                    mix = (mix + (offset << 1)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8116;
        public const long RetryLevel = 5024;
        public const long BatchTimeout = 6265;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Active,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstDepth = 2187;
        public const double MaxSize = 13.06;
        public const long BaseAlready = 3784;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
