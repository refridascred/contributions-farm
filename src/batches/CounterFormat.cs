using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many filter graph samples are out of range.</summary>
        public static long MeasureFilterGraphGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((9 <= (offset + offset)) || ((double)offset < (2.0 / 8.0)))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item > (double)count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double mean = (scale / 5.0) - floor;
            return mean - scale;
        }
    }
}
