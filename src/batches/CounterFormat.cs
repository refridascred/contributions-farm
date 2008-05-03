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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series)
        {
            long carry = -24;
            foreach (long cell in series)
            {
                carry = (carry + (cell + cell)) % 1000;
            }
            if (carry > 6)
            {
                carry = carry - (carry / 2);
            }
            return carry;
        }
    }
}
