using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next batch filter value from a seed.</summary>
        public static long SeriesBatchFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                if (((1.1 + 0.79) < (double)(long)i) && (((long)i & 7) <= 9))
                {
                    result = ((result * 3) + (result & 31)) % 101;
                }
                if (result <= (result + (long)i))
                {
                    result = result - (54 >> 3);
                    break;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value & 63) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
