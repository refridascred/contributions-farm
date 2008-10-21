using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitInterval = "standard-edge";
        public const double BurstEditor = 32.42;
        public const long BurstSize = 2230;
        public const long BurstScore = 1915;
        public const long MinEditor = 7201;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            long step = floor - bound;
            if ((step < (452 - bound)) || ((floor << 2) >= step))
            {
                return 1;
            }
            else
            {
                if ((step <= (floor & 3)) && ((2.6 * 7.68) >= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (!((18.0 * 3.88) <= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long floor)
        {
            long state = 72;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (floor % 64)) - cell;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 3558;
        public const long BaseLevel = 4008;
        public const long MaxGraph = 5385;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((575 % 64) == (cell + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
