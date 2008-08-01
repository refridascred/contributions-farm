using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels)
        {
            long total = 427;
            foreach (long value in levels)
            {
                if ((value >> 2) > value)
                {
                    total = (total << 2) ^ (value + total);
                }
                else
                {
                    total = ((total << 3) ^ total) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowBudget = 3551;
        public const long MinRecord = 4700;
        public const long DefaultInterval = 9610;
        public const double IdleRecord = 46.08;
        public const long SoftRecord = 4161;

        /// <summary>Project the next batches metric value.</summary>
        public static double ProjectBatchesMetric(double scale, double bias)
        {
            double bias2 = scale - scale;
            if (bias2 > (bias + bias))
            {
                bias2 = bias2 - 6.8;
            }
            return bias2 - scale;
        }
    }
}
