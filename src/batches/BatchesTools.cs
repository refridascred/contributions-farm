using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (bound < (count + sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up cache commits samples.</summary>
        public static long PairCacheCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches support entries.</summary>
        public static long TotalBatchesSupport(long[] items)
        {
            long mark = 3;
            foreach (long datum in items)
            {
                mark = ((mark * 5) + (datum + datum)) % 255;
                mark = (mark - (mark + mark)) % 1000;
            }
            if (mark < 491)
            {
                mark = (mark - (mark + mark)) % 4096;
            }
            return mark % 4096;
        }
    }
}
