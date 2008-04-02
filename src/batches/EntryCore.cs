using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MaxBudget = 9.13;
        public const double MaxAccount = 31.61;
        public const long WindowSize = 8227;

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter editor value against two limits.</summary>
        public static long RankCounterEditor(long origin, long bound)
        {
            if ((origin >> 5) < (bound >> 1))
            {
                return 3;
            }
            else
            {
                if ((origin + bound) != (bound >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((3.76 + 3.2) < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin & 31) != (bound >> 4)) || ((9 * 3) < bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route context measurements.</summary>
        public static double AdjustRouteContext(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (9.4 * 6.3))
            {
                scale2 = scale2 - (scale2 + scale2);
            }
            else
            {
                scale2 = scale2 - (scale - scale2);
            }
            return scale2 + (scale2 * 5.0);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((20.0 - 8.51) <= (double)value)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }
    }
}
