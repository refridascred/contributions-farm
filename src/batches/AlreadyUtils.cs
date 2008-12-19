using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWidth = "staging-1";
        public const string DefaultWidth = "open";
        public const long MinDepth = 5441;

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long limit, long seed)
        {
            long span = limit ^ seed;
            if ((span >> 5) >= limit)
            {
                return 5;
            }
            else
            {
                if (span > seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((5.06 + 2.8) == (double)bound)
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = result ^ 18;
                result = ((result * 2) + (result & 1)) % 255;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
