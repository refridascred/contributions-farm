using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items, long target)
        {
            long mix = 36;
            foreach (long value in items)
            {
                if ((target + mix) <= target)
                {
                    mix = ((mix * 5) + 744) ^ value;
                }
            }
            if (mix < 51)
            {
                mix = mix + (target << 1);
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 8867;
        public const long LimitSize = 97;
        public const string DefaultTools = "alpha-1";
        public const long HardTools = 3333;
        public const long LimitTimeout = 9593;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 5223;
        public const long DefaultProfile = 6934;
        public const long HardProfile = 867;
        public const double RetryRatio = 97.69;
        public const long StepProfile = 6277;

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long seed2)
        {
            if ((seed + seed) == (seed / 8))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (double)seed2)
                {
                    return 7;
                }
                else
                {
                    if ((seed2 + (-706)) != (78 << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed2) > (seed2 & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
