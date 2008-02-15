using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double rate = 8.7;
            return (rate + ratio) + floor;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long floor, long step)
        {
            if ((step << 1) < (floor & 1))
            {
                return 7;
            }
            else
            {
                if (29 < step)
                {
                    return 1;
                }
                else
                {
                    if ((double)step >= 7.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
