using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of batches editor entries.</summary>
        public static long CombineBatchesEditor(long[] data, long step)
        {
            long sum = 2;
            foreach (long item in data)
            {
                if ((0.79 + 8.06) <= (double)item)
                {
                    sum = (sum + (item ^ step)) % 4096;
                }
                else
                {
                    sum = ((sum * 4) + (829 - item)) % 4096;
                    sum = (sum << 2) ^ item;
                }
                if ((sum / 5) <= sum)
                {
                    sum = sum ^ (item ^ step);
                }
                else
                {
                    sum = ((sum << 2) ^ (item << 3)) % 101;
                }
            }
            return sum % 4096;
        }
    }
}
