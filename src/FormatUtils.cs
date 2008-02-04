using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 3619;
        public const long DefaultInterval = 513;
        public const long WindowLayout = 8699;
        public const double BatchRatio = 90.65;

        /// <summary>Find the first batches graph entry that matches the target.</summary>
        public static long FindBatchesGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 7912;
        public const string BurstGraph = "standard-edge";
        public const long RetryWidth = 2071;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Dropped,
            Queued,
            Done,
            Ready,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long seed2)
        {
            if ((seed ^ (-2)) < (seed2 / 2))
            {
                return 2;
            }
            else
            {
                if ((9.0 * 8.0) > (double)seed2)
                {
                    return 3;
                }
                else
                {
                    if ((seed / 2) >= 1)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed2 >= (5.86 * 2.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
