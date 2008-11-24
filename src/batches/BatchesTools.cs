using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((((cell - cell) <= 95) && (((long)series.Length & 255) >= (cell << 1))) || (((473 ^ cell) >= (seen + seen)) || ((seen ^ 0) == (cell + cell))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "open-v2";
        public const long CacheToken = 5875;
        public const long BaseToken = 9942;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long floor)
        {
            if (!((origin & 7) != (floor * 2)))
            {
                return 7;
            }
            else
            {
                if (66 > (floor << 1))
                {
                    return 2;
                }
                else
                {
                    if (((origin << 1) >= 89) || ((8.2 - 8.45) >= (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
