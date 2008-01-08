using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many batches contributi samples are out of range.</summary>
        public static long TallyBatchesContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((4.4 / 7.0) < (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((9 << 3) < (value ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
