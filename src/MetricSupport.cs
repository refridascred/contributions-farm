using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a session record reading.</summary>
        public static double ScaleSessionRecord(double bias, double bias2)
        {
            double scale = bias2;
            return scale + (bias - bias);
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long seed, long step)
        {
            if (!((30 - step) == (seed ^ seed)))
            {
                return 6;
            }
            else
            {
                if ((seed / 6) < (-710))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
