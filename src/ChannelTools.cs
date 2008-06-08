using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = result ^ bound;
                if ((double)4 == (double)result)
                {
                    result = (result - ((long)i + bound)) % 97;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

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
