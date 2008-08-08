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

        /// <summary>Grade a stats editor value against two limits.</summary>
        public static long ClassifyStatsEditor(long target, long limit)
        {
            long prev = target - limit;
            if (!((7.2 + 8.0) < (double)target))
            {
                return 1;
            }
            else
            {
                if ((prev / 3) > (target >> 3))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
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
