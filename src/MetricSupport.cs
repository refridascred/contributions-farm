using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 1769;
        public const double DefaultBudget = 93.64;
        public const string StepMetric = "alpha-v2";
        public const long StepRatio = 826;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 6178;
        public const double HardRatio = 29.78;
        public const long BatchFactor = 5868;
    }
}
