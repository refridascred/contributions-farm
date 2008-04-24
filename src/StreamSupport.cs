using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((double)step < (7.9 / 4.0)) || ((entry << 2) <= step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches + matches) >= matches) && !((double)matches >= (5.3 * 3.8)))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
