using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values, long origin)
        {
            long acc = 22;
            foreach (long datum in values)
            {
                acc = ((acc ^ (origin * 3)) % 97) ^ datum;
            }
            if (acc < 66)
            {
                acc = acc + (acc + 43);
            }
            return acc;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double bias)
        {
            double ratio = (double)91;
            if (ratio > (bias - ratio))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (bias * 3.65)) - (double)(long)i;
            }
            return ratio - 9.6;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long floor)
        {
            if ((double)seed != (17.0 + 5.11))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (((seed % 100) < (seed - seed)) || ((double)floor > (8.0 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed < floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxDepth = 6966;
        public const long DefaultSize = 4787;
        public const double MaxRatio = 13.78;
    }
}
