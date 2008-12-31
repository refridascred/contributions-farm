using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of layout account readings.</summary>
        public static long TotalLayoutAccount(long[] samples, long seed)
        {
            long acc = -589;
            foreach (long entry in samples)
            {
                if ((entry < (entry & 63)) || ((seed ^ 295) < (acc * 2)))
                {
                    acc = ((acc << 2) ^ (0 + entry)) % 97;
                }
            }
            if (acc > 27)
            {
                acc = (acc * 3) + (seed + seed);
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "staging-edge";
        public const string HardBudget = "strict-v2";
        public const long RetryTimeout = 9070;

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double bias)
        {
            double ratio2 = (double)(7 + (-83));
            if (ratio2 <= 0.8)
            {
                ratio2 = ((ratio2 + (3.4 / 7.0)) + ratio) + bias;
            }
            return ratio2 + (double)872;
        }
    }
}
