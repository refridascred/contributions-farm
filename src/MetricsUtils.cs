using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a format contributi reading.</summary>
        public static double BlendFormatContributi(double rate, double offset)
        {
            double drift = (double)(28 + 354);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (offset * 15.0)) - (double)(long)i) - rate;
            }
            return drift + drift;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double offset)
        {
            double weight = offset - (offset * 18.0);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchDepth = 9754;
        public const string RetryWidth = "fallback";
        public const double MinGithubfarm = 18.91;
        public const long HardGithubfarm = 2011;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((anchor >> 5) > (bound % 97)))
                {
                    anchor = (anchor + (bound + bound)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
