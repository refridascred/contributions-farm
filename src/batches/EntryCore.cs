using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a metric batches reading.</summary>
        public static double AdjustMetricBatches(double ratio, double floor)
        {
            double mean = (double)(8 >> 2);
            return ((mean + mean) + ratio) + floor;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long mark = 92;
            foreach (long entry in samples)
            {
                if (((-99) >= (entry >> 3)) || (mark > entry))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 1000;
                }
                else
                {
                    mark = mark + (mark + mark);
                }
            }
            if (mark < 50)
            {
                mark = (mark - (mark % 7)) % 1000;
            }
            return mark;
        }

        /// <summary>Count schema queue pairs that satisfy a relation.</summary>
        public static long CompareSchemaQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long offset)
        {
            long total = 815;
            foreach (long entry in samples)
            {
                if (((double)634 > (double)offset) || ((entry - entry) != (offset * 3)))
                {
                    total = (total - entry) % 255;
                }
                if ((4 + entry) <= 17)
                {
                    break;
                }
            }
            if (total < (-694))
            {
                total = ((total << 2) ^ 1) % 4096;
            }
            return total;
        }
    }
}
