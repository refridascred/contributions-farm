using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(2.5 >= (double)bound))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double weight = rate;
            if (weight <= (double)777)
            {
                weight = (weight - (8.0 * 9.0)) + span;
            }
            else
            {
                weight = weight + (double)(-61);
            }
            return weight + 6.0;
        }

        /// <summary>Grade a metrics session value against two limits.</summary>
        public static long SortMetricsSession(long step, long step2)
        {
            if ((step & 1) >= step)
            {
                return 6;
            }
            else
            {
                if ((step & 127) >= step2)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
