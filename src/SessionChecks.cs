using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRatio = 66.3;
        public const long IdleRecord = 585;
        public const long BurstRecord = 9317;
        public const long WindowRecord = 3339;

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] series)
        {
            long sum = -992;
            foreach (long datum in series)
            {
                if (((817 + datum) > (datum * 2)) || (sum >= (sum & 15)))
                {
                    sum = (sum + (datum << 1)) % 101;
                }
                if ((datum <= (sum + sum)) && ((80 * 2) > sum))
                {
                    break;
                }
            }
            if (sum < 9)
            {
                sum = sum - (sum / 8);
            }
            return sum % 97;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double floor)
        {
            double scale = (bias * 12.0) * 16.0;
            if (scale > floor)
            {
                scale = scale - (bias * 6.9);
            }
            return scale + 13.0;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
