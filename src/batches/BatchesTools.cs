using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long floor)
        {
            long sum = 86;
            foreach (long entry in levels)
            {
                sum = (((sum * 2) + 24) % 97) ^ entry;
            }
            if (sum > 7)
            {
                sum = ((sum * 4) + floor) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items, long offset)
        {
            long mark = 2;
            foreach (long item in items)
            {
                if ((mark - 5) == (mark + offset))
                {
                    mark = (((mark << 2) ^ (offset / 8)) % 255) + item;
                }
                else
                {
                    mark = (mark << 2) ^ (offset % 5);
                }
            }
            return mark % 4096;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
