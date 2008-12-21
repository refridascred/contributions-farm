using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double floor)
        {
            double ratio2 = (8.8 + floor) - ratio;
            if (ratio2 > (ratio + ratio2))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 - ratio2);
            }
            return ratio2 - ratio2;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((557 - origin) < (origin - state))
                {
                    state = (state + (origin + (long)i)) % 65521;
                    state = (state * 2) + (state - state);
                }
                state = state - state;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
