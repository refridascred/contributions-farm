using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (34 >= (item / 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits ^ limit) != (hits % 10))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
