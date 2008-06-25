using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 3328;
        public const double SoftCount = 83.24;
        public const string HardInterval = "standard-1";
        public const string BurstRatio = "fallback-v2";
        public const long BurstPayload = 2633;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long floor)
        {
            long offset = seed + floor;
            if (!((20.0 / 2.0) >= (double)offset))
            {
                return 3;
            }
            else
            {
                if ((95 >> 4) >= seed)
                {
                    return 0;
                }
                else
                {
                    if (!(floor <= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor / 9) != (offset + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
