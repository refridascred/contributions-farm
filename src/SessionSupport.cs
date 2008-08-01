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

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 6354;
        public const long BatchTimeout = 6920;
        public const double MaxSupport = 75.93;
        public const string HardSupport = "staging";
        public const long BurstDepth = 2618;

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
