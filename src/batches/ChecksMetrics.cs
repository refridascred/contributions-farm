using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Locked,
            Failed,
        }

        /// <summary>Locate a account notes reading by value.</summary>
        public static long SeekAccountNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Done,
            Failed,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the record entry entries that pass the check.</summary>
        public static long MeasureRecordEntryHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((3.5 - 10.0) <= (double)seed)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
