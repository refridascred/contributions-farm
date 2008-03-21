using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally * 2) < item)
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long bound, long offset)
        {
            long diff = bound + offset;
            if (diff > (offset * 2))
            {
                return 1;
            }
            else
            {
                if ((5.1 * 3.1) <= (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
