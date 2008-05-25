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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
