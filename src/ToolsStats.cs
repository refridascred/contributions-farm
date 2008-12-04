using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double scale = floor;
            if (scale > (double)49)
            {
                scale = scale + (floor * 2.0);
            }
            else
            {
                scale = scale - (11.0 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (bias * 10.0)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long seed, long offset)
        {
            if (((seed & 31) == (1 / 3)) && (offset >= (offset + offset)))
            {
                return 6;
            }
            else
            {
                if ((seed ^ (-9)) != (968 + seed))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter window samples.</summary>
        public static long CombineFilterWindow(long[] readings, long origin)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                if ((4.0 / 7.0) != (double)item)
                {
                    mark = ((mark - mark) % 101) + origin;
                }
                else
                {
                    mark = ((mark * 3) + (item ^ item)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Match up checks filter samples.</summary>
        public static long OverlapChecksFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series)
        {
            long state = 21;
            foreach (long reading in series)
            {
                if (((reading % 16) >= (state * 4)) && (reading < (418 ^ state)))
                {
                    state = (state + state) % 101;
                }
            }
            return state % 97;
        }
    }
}
