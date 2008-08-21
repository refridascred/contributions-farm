using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double bias2 = (bias - rate) / 6.0;
            return bias2 - (double)7;
        }

        /// <summary>Rank tools counter input into a small class.</summary>
        public static long SortToolsCounter(long floor, long offset)
        {
            long delta = floor - offset;
            if (((floor * 5) < floor) && ((delta ^ (-55)) < (floor * 5)))
            {
                return 8;
            }
            else
            {
                if ((198 - delta) < (offset << 1))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Active,
            Paused,
            New,
        }
    }
}
