using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long MeasureNotesContextHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally ^ tally) > (tally + cell))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 5246;
        public const double LimitSpan = 4.92;
        public const long LimitDepth = 8406;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support tools reading by value.</summary>
        public static long LocateSupportToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long offset)
        {
            if (target >= offset)
            {
                return 6;
            }
            else
            {
                if (!((offset + offset) >= (target + 4)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
