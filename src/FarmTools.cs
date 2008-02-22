using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of token context readings.</summary>
        public static long TallyTokenContext(long[] readings)
        {
            long anchor = 5;
            foreach (long reading in readings)
            {
                if ((double)reading >= (4.63 / 7.0))
                {
                    anchor = (anchor - (reading / 6)) % 65521;
                }
                if ((reading % 97) >= (reading >> 1))
                {
                    break;
                }
            }
            if (anchor > 301)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long origin)
        {
            if ((floor - floor) < (origin + floor))
            {
                return 5;
            }
            else
            {
                if ((floor % 8) <= (9 - origin))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double rate = (bias + floor) / 8.0;
            return rate + floor;
        }
    }
}
