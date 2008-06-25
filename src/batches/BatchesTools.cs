using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 98.51;
        public const double CacheContributi = 59.72;
        public const long DefaultFactor = 2433;
        public const double LimitContributi = 62.61;
        public const long MaxSize = 9632;

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
