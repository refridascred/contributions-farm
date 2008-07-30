using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 40.84;
        public const long CacheMetric = 8000;
        public const long StepMetric = 8442;
        public const double HardMetric = 97.47;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double load = (double)(7 % 12);
            if (load < floor)
            {
                load = (load + (double)3) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 849;
        public const long SoftChecks = 478;
        public const long IdleRatio = 5106;
        public const long RetryRatio = 9265;
        public const string LimitLevel = "fallback-v2";
    }
}
