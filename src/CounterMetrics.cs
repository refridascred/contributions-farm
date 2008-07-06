using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels, long limit)
        {
            long mix = 3;
            foreach (long entry in levels)
            {
                mix = ((mix + (limit * 5)) % 97) ^ entry;
            }
            return mix % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxBudget = 1568;
        public const double BaseFilter = 90.04;
        public const long MaxFilter = 8216;
        public const double LimitFilter = 6.32;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)(long)levels.Length <= (17.0 / 4.0))
                {
                    matches = ((matches + 3) ^ item) - target;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
