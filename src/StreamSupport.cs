using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7290;
        public const long DefaultInterval = 7809;
        public const long BaseTools = 7084;

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series)
        {
            long sum = 907;
            foreach (long cell in series)
            {
                sum = (sum ^ (cell + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Count metrics window pairs that satisfy a relation.</summary>
        public static long CompareMetricsWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
