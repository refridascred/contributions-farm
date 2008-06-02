using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long limit)
        {
            long total = 133;
            foreach (long item in items)
            {
                if (((-83) + item) >= (total << 1))
                {
                    total = ((total + total) % 97) + limit;
                }
            }
            if (total > 747)
            {
                total = total + (total - total);
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry <= 5)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
