using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double scale2 = scale + (scale - bias);
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale + scale2)) + (double)(long)i;
            }
            return scale2 - (scale - 2.3);
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstBudget = 5929;
        public const long HardTimeout = 6800;
        public const long BatchFactor = 1630;
        public const long StepLayout = 3779;
        public const long CacheLayout = 4434;
    }
}
