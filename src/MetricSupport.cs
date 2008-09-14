using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 9375;
        public const long WindowTimeout = 8924;
        public const long BaseCount = 3499;

        /// <summary>Blend two session stream measurements.</summary>
        public static double BlendSessionStream(double weight, double bias)
        {
            double scale = bias;
            return (scale - (double)857) + weight;
        }

        /// <summary>Locate a farm contributi reading by value.</summary>
        public static long FindFarmContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
