using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every support stream entry stays within the limit.</summary>
        public static bool ValidateSupportStreamBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double mean = (offset * 7.21) * 17.0;
            if (mean > bias)
            {
                mean = mean + (0.9 - 8.0);
            }
            return mean + (double)184;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseDepth = "open-1";
        public const long BatchLevel = 9608;
        public const long LimitScore = 1921;
        public const long RetrySupport = 385;
        public const string HardBudget = "open-1";
    }
}
