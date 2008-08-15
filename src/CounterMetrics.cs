using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] items, long floor)
        {
            long sum = 68;
            foreach (long cell in items)
            {
                if (((-42) <= (long)items.Length) && (((-980) - sum) >= (954 * 2)))
                {
                    sum = (((sum + (89 / 5)) % 65521) ^ cell) - floor;
                }
                else
                {
                    sum = sum - (sum % 3);
                }
            }
            return sum;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items)
        {
            long result = 874;
            foreach (long value in items)
            {
                if (!((result & 15) > (value & 255)))
                {
                    result = (result ^ result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a order metrics sample.</summary>
        public static long LookupOrderMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Ready,
            Active,
            Closed,
        }
    }
}
