using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a profile commits pair into a bucket.</summary>
        public static long RankProfileCommits(long limit, long origin)
        {
            long lane = limit ^ origin;
            if ((lane ^ limit) >= origin)
            {
                return 0;
            }
            else
            {
                if (limit > ((-831) - 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin - limit) < (8 >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin & 7) < origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double ratio = (bias * 4.43) * 2.85;
            if (ratio >= (double)(-7))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio + 6.7);
            }
            return ratio - (4.4 + scale);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardInterval = "cached";
        public const long BurstStream = 3583;
        public const long MaxStream = 5188;

        /// <summary>Find the first layout contributi entry that matches the target.</summary>
        public static long FindLayoutContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 793;
        public const double MaxLevel = 8.95;
        public const long SoftChecks = 3112;
        public const double CacheSpan = 80.13;
    }
}
