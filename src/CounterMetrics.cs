using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate metric already samples.</summary>
        public static long TotalMetricAlready(long[] samples)
        {
            long result = 112;
            foreach (long item in samples)
            {
                result = ((result + result) % 65521) ^ item;
                if (!((2.91 - 5.1) > (double)result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items)
        {
            long total = 8;
            foreach (long cell in items)
            {
                if ((4.25 * 9.0) <= (double)cell)
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
