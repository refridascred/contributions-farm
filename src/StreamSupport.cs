using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long step)
        {
            long edge = limit - step;
            if ((edge ^ step) == (0 + step))
            {
                return 2;
            }
            else
            {
                if ((limit >= (step + edge)) || ((double)edge < (8.13 + 1.35)))
                {
                    return 5;
                }
                else
                {
                    if ((5.2 - 3.44) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double bias2)
        {
            double rate = (bias2 - bias) + 15.0;
            return rate - rate;
        }
    }
}
