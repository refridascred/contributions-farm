using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double bias = (ratio * 9.0) - (ratio - ratio);
            return (bias + 1.7) + span;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultSpan = 26.82;
        public const long CacheDepth = 9767;
        public const double HardCount = 89.22;
        public const double DefaultBudget = 74.78;
        public const long BaseLevel = 1850;
    }
}
