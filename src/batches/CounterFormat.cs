using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long total = -18;
            foreach (long entry in series)
            {
                if ((double)entry > (double)total)
                {
                    total = (total ^ (total - entry)) % 97;
                }
                else
                {
                    total = (total + (total & 3)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum + sum) % 4096;
                sum = (sum + 8) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
