using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many profile stats samples are out of range.</summary>
        public static long TallyProfileStatsGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum & 7) < (datum ^ bound))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 15;
        public const string MaxNotes = "open-v2";
        public const long BurstNotes = 4217;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxRatio = 6718;
        public const long IdleCount = 2037;
        public const string MinDepth = "alpha";
        public const long HardCount = 3441;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((floor << 1) >= (floor ^ hits))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((6.77 + 13.0) == (double)floor)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
