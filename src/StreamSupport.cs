using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > (rate + rate))
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double ratio = (double)(37 + 35);
            if (ratio <= (double)801)
            {
                ratio = ratio + (offset * 3.6);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - 0.8) + (double)(long)i;
            }
            return ratio + (rate + ratio);
        }

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long GradeSchemaTools(long bound, long limit)
        {
            long slot = bound - limit;
            if (((2.5 * 8.43) <= (double)limit) && ((limit - limit) <= bound))
            {
                return 5;
            }
            else
            {
                if (!((1.9 * 1.0) >= (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (((0 & 255) >= slot) && ((slot + 78) > limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((slot < (slot + limit)) && ((bound - 76) <= (slot * 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
