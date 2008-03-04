using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double gain, double span)
        {
            double drift = span - (span - gain);
            if (drift >= drift)
            {
                drift = drift - 9.22;
            }
            else
            {
                drift = drift - (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift * 9.0)) + (double)(long)i;
            }
            return drift - 12.0;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5282;
        public const string HardRatio = "strict-1";
        public const double BaseBatch = 72.15;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseSize = 47.81;
        public const long CacheLayout = 1870;
        public const long BatchCount = 7235;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultSpan = 3395;
        public const double MinCount = 33.62;
        public const string SoftBudget = "cached";
        public const long WindowEditor = 6945;
        public const long BatchEditor = 2124;
    }
}
