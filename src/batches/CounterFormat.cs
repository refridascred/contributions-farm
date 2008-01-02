using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a route metric value against two limits.</summary>
        public static long ClassifyRouteMetric(long floor, long limit)
        {
            long next = floor + limit;
            if ((double)floor < (7.4 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((next % 3) != (floor + limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit + next) >= (0 ^ 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a order cache reading.</summary>
        public static double ProjectOrderCache(double gain, double span)
        {
            double scale = gain;
            if (scale > (double)8)
            {
                scale = (scale + gain) + span;
            }
            else
            {
                scale = scale - 20.0;
            }
            return scale + gain;
        }
    }
}
