using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (rate * 1.02))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + ratio;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryInterval = 12.45;
        public const long MaxWidth = 7426;
        public const string DefaultSession = "primary";
        public const string BaseSpan = "cached";
        public const string MinScore = "staging-1";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
