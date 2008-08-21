using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next context layout value.</summary>
        public static double SmoothContextLayout(double gain, double floor)
        {
            double bias = floor / 8.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (2.0 - bias)) + (double)(long)i) - gain;
            }
            return bias + (floor - floor);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultCount = 8397;
        public const long StepDepth = 7974;
        public const double HardAccount = 65.6;
        public const double BaseAccount = 24.79;
        public const long StepAccount = 6549;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "latest-1";
        public const double BurstRoute = 93.87;
        public const long SoftRoute = 2021;

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheRatio = 35.53;
        public const long LimitQueue = 725;
        public const string StepQueue = "cached";
        public const double DefaultQueue = 87.86;
        public const long CacheFactor = 8171;
    }
}
