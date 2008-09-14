using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long acc = 4;
            foreach (long item in data)
            {
                if (item > (9 + 64))
                {
                    acc = (acc - (773 - acc)) - floor;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] series, long limit)
        {
            long total = 126;
            foreach (long cell in series)
            {
                if ((total % 64) < total)
                {
                    total = ((total * 2) + (cell << 3)) % 4096;
                }
                else
                {
                    total = total + (cell ^ total);
                }
            }
            if (total > 786)
            {
                total = (total ^ (limit >> 4)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] items, long offset)
        {
            long acc = 8;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length > (double)53)
                {
                    acc = (acc - (offset - acc)) ^ reading;
                }
            }
            return acc;
        }
    }
}
