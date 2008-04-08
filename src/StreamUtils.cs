using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if ((acc < 2) && ((long)i < target))
                {
                    acc = ((acc * 3) + target) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of batch checks readings.</summary>
        public static long WeighBatchChecks(long[] levels, long bound)
        {
            long sum = 3;
            foreach (long item in levels)
            {
                sum = ((sum << 3) ^ 8) % 65521;
                sum = (sum << 3) ^ (837 - item);
                if ((double)bound <= (6.0 + 18.0))
                {
                    sum = ((sum * 3) + (64 >> 1)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((state < ((-22) - offset)) && ((long)i <= offset))
                {
                    state = (state ^ (state - offset)) % 101;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits * 4) > (item * 4))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 4364;
        public const string MinWindow = "fallback";
        public const long BurstInterval = 63;
        public const long MaxCount = 56;
    }
}
