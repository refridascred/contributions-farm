using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxInterval = 8827;
        public const long IdleQueue = 9624;
        public const string HardRatio = "stable-1";
        public const double BurstWidth = 55.83;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            long delta = seed + offset;
            if ((delta + offset) >= seed)
            {
                return 3;
            }
            else
            {
                if (((delta / 2) > seed) || ((offset * 3) < delta))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 1) >= 6)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 3833;
        public const string IdleWindow = "primary-v2";
        public const double IdleSpan = 36.19;
        public const long WindowBudget = 9131;
    }
}
