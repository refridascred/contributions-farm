using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit record order readings against a rule.</summary>
        public static long AuditRecordOrderMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((4 & 7) >= (reading - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the counter batches entries that pass the check.</summary>
        public static long MeasureCounterBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2.0 * 7.0) != (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((7.0 * 9.0) > (double)datum))
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
