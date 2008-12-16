using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "local-edge";
        public const long CacheBuffer = 1590;
        public const long BurstDepth = 2776;
        public const string BatchBuffer = "stable-v2";

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
