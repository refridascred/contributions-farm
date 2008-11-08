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

        /// <summary>Look up the position of a session report sample.</summary>
        public static long LookupSessionReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
