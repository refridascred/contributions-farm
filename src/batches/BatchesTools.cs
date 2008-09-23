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

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((6.0 - 3.2) < (double)limit)
                {
                    acc = (acc ^ (5 % 8)) % 255;
                    acc = acc + (long)i;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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
