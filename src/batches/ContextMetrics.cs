using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double floor)
        {
            double rate = floor + floor;
            if (rate <= (5.22 + rate))
            {
                rate = (rate - rate) - gain;
            }
            return rate + 3.68;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "latest-edge";
        public const long CacheRatio = 1353;
        public const string BurstFarm = "local-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseScore = 10.0;
        public const long StepSize = 1935;
        public const long DefaultCount = 9622;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 916;
        public const long WindowContributi = 470;
        public const long StepContributi = 562;
        public const double SoftDepth = 28.58;
    }
}
