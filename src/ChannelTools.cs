using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 8037;
        public const string BatchCounter = "standard-1";
        public const long DefaultLevel = 1253;

        /// <summary>Grade a report stream value against two limits.</summary>
        public static long SortReportStream(long limit, long seed)
        {
            if (((15.0 / 5.0) != (double)limit) && ((4.46 + 7.4) <= (double)seed))
            {
                return 5;
            }
            else
            {
                if ((0.74 > (double)seed) || ((double)seed < 0.3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = rate + (5.0 - ratio);
            }
            else
            {
                rate = rate + (floor * 3.92);
            }
            return rate + 1.8;
        }
    }
}
