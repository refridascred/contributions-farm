using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a report filter reading.</summary>
        public static double ScaleReportFilter(double ratio, double bias)
        {
            double scale = bias * 7.5;
            if (scale <= 11.0)
            {
                scale = (scale - scale) + ratio;
            }
            return scale - (double)3;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long origin)
        {
            if (((bound + 3) == (origin ^ bound)) && ((double)origin == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((double)49 > (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((bound + 9) < (origin ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound <= (7.0 / 2.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 522;
        public const long WindowChannel = 4294;
        public const long IdleChannel = 8249;
    }
}
