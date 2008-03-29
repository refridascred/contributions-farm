using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double scale = floor;
            if (scale > gain)
            {
                scale = scale + (floor - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (scale + floor);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long seed)
        {
            if (offset <= (54 - seed))
            {
                return 8;
            }
            else
            {
                if ((seed < (offset + offset)) && ((seed + offset) != (7 - offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset + 38) >= (seed / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed << 3) > seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cluster cache value.</summary>
        public static double ScaleClusterCache(double ratio, double span)
        {
            double load = ratio;
            if (load <= (double)212)
            {
                load = (load - (7.0 * 7.4)) - span;
            }
            else
            {
                load = load - 12.0;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (ratio / 8.0)) - (double)(long)i;
            }
            return load + (ratio / 3.0);
        }
    }
}
