using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count cache contributi pairs that satisfy a relation.</summary>
        public static long CompareCacheContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels)
        {
            long sum = -3;
            foreach (long sample in levels)
            {
                if ((sum / 8) >= sum)
                {
                    sum = ((sum ^ (247 % 60)) % 65521) ^ sample;
                }
            }
            if (sum < 0)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }
    }
}
