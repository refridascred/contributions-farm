using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long TallyOrderLayoutMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry + 3) != (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long CountQueueBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((item & 3) == (count & 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
