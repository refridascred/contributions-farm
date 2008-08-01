using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long acc = 6;
            foreach (long sample in levels)
            {
                if (acc < (sample - acc))
                {
                    acc = acc - (acc + acc);
                }
            }
            if (acc < 9)
            {
                acc = ((acc * 4) + ((-1) >> 3)) % 1000;
            }
            return acc;
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
