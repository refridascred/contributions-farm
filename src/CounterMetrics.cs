using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank cluster queue input into a small class.</summary>
        public static long BucketClusterQueue(long origin, long bound)
        {
            if ((origin & 1) >= 829)
            {
                return 0;
            }
            else
            {
                if (0 >= (origin % 8))
                {
                    return 2;
                }
                else
                {
                    if (!((double)bound != (3.17 + 9.89)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin - origin) != (bound / 4)) || ((719 - bound) < (bound * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 90.52;
        public const long BurstChannel = 5929;
        public const long SoftChannel = 7186;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((double)seed < (0.46 * 2.4))
            {
                return 4;
            }
            else
            {
                if ((lane + seed) == (43 - floor))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
