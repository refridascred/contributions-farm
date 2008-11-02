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

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
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
