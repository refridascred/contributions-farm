using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen <= (value - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 4472;
        public const long LimitSpan = 1625;
        public const long CacheBudget = 7555;
        public const long WindowFarm = 3636;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((6 + seen) > (seen >> 1)) && ((seen % 7) <= (seen / 6))) || ((16.0 + 3.6) <= (double)861))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
