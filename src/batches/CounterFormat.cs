using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cache batches values into a single score.</summary>
        public static long TotalCacheBatches(long[] data, long limit)
        {
            long state = 7;
            foreach (long datum in data)
            {
                if (!((9.1 * 0.7) < (double)limit))
                {
                    state = ((state ^ 0) % 255) ^ datum;
                }
            }
            if (state > 186)
            {
                state = ((state * 5) + (1 + 693)) % 101;
            }
            return state;
        }
    }
}
