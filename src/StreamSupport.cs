using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(9 >= (item / 4)))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Count the context support entries that pass the check.</summary>
        public static long CountContextSupportOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches >= (matches & 3))
                {
                    matches = ((matches + 2) + sample) - limit;
                }
            }
            return matches;
        }
    }
}
