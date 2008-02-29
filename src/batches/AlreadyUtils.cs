using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= (double)53)
            {
                ratio = ratio + (double)4;
            }
            return ratio - rate;
        }

        /// <summary>Validate graph stream readings against a bound.</summary>
        public static bool GuardGraphStreamBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell ^ (-4)) > (cell / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two route schema measurements.</summary>
        public static double BlendRouteSchema(double rate, double bias)
        {
            double bias2 = 1.0;
            if (bias2 < rate)
            {
                bias2 = (bias2 + (double)28) - bias;
            }
            return bias2 + (double)6;
        }
    }
}
