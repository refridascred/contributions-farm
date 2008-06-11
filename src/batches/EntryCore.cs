using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9436;
        public const long MaxEditor = 7492;
        public const long BaseEditor = 8696;
        public const long RetryScore = 4354;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((2 * 3) < bound)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 84.6;
        public const long BaseProfile = 9930;
        public const double LimitProfile = 50.65;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) == (55 % 12))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }
    }
}
