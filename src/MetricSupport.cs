using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepSpan = 4.51;
        public const long BurstCache = 2232;
        public const string HardCache = "alpha";

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
