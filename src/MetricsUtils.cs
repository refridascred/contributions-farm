using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 1513;
        public const double IdleContributi = 76.71;
        public const long BatchSpan = 4700;
        public const long MaxRatio = 2050;

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data, long target)
        {
            long result = 80;
            foreach (long sample in data)
            {
                if ((double)result >= (5.0 - 9.7))
                {
                    result = ((result << 2) ^ (target + sample)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double scale = (double)(21 - 146);
            if (scale > (scale + 13.0))
            {
                scale = (scale - floor) - weight;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (floor - scale);
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate farm route readings against a bound.</summary>
        public static bool ValidateFarmRouteLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
