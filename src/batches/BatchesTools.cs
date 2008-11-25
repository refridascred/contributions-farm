using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleTimeout = 8105;
        public const long BatchMetric = 5894;
        public const long CacheMetric = 5845;
        public const long BurstMetric = 1379;
        public const long LimitMetric = 2725;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values)
        {
            long total = 5;
            foreach (long value in values)
            {
                if ((8 % 12) < value)
                {
                    total = (total ^ ((long)values.Length - total)) % 255;
                }
                if ((total >> 2) < 56)
                {
                    total = (total - total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
