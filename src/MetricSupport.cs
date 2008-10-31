using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCount = 2553;
        public const string RetryCluster = "fallback";
        public const string BatchFactor = "strict-v2";
        public const double MinInterval = 76.64;

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double ratio, double offset)
        {
            double weight = (ratio * 2.6) * 14.0;
            if (weight <= (double)3)
            {
                weight = weight + weight;
            }
            return weight + (offset - offset);
        }
    }
}
