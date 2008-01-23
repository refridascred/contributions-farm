using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseWidth = 61.72;
        public const double MaxMetrics = 31.84;
        public const long StepMetrics = 5636;
        public const string DefaultFactor = "strict-1";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i % 2) >= 784)
                {
                    mix = (mix - (mix >> 4)) % 4096;
                    mix = mix - limit;
                }
                else
                {
                    long diff = (limit + (long)i) + (mix >> 5);
                    mix = (mix + (diff / 4)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - (long)i) % 101;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (score << 1)) % 255;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
