using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 7194;
        public const long SoftLevel = 7110;
        public const long BatchEditor = 599;
        public const double MaxWidth = 10.67;
        public const long MinDepth = 8949;

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstSize = 94.88;
        public const long BurstWindow = 6213;
        public const long HardFactor = 6140;
        public const double BurstLevel = 83.17;
        public const long CacheCount = 2034;

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double gain2 = (double)(509 * 3);
            if (gain2 >= 7.5)
            {
                gain2 = (gain2 + 12.0) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (gain * 6.0)) + (double)(long)i;
            }
            return gain2 + (double)863;
        }
    }
}
