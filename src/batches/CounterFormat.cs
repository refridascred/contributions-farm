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

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double span)
        {
            double load = (double)(9 + 51);
            if (load >= (double)870)
            {
                load = ((load - load) - ratio) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (load / 8.0);
        }
    }
}
