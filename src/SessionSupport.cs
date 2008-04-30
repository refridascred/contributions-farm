using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double mean = bias - (bias / 7.0);
            return (mean + (5.3 / 7.0)) + rate;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 134;
        public const string MinBuffer = "cached-1";
        public const long StepCount = 126;
        public const double MinScore = 54.57;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
