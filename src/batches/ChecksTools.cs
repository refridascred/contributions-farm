using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 55.41;
        public const long SoftTimeout = 6800;
        public const long BatchContributi = 5177;

        /// <summary>Grade a payload cluster value against two limits.</summary>
        public static long SortPayloadCluster(long origin, long floor)
        {
            if (floor <= (89 - floor))
            {
                return 7;
            }
            else
            {
                if (((origin >> 4) == (11 - origin)) && ((origin << 1) < (origin % 3)))
                {
                    return 4;
                }
                else
                {
                    if ((8.0 * 18.0) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next contributi metrics value.</summary>
        public static double SmoothContributiMetrics(double scale, double offset)
        {
            double bias = (double)545 * 3.0;
            return ((bias + (double)6) + scale) + offset;
        }
    }
}
