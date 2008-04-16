using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the graph stream entries that pass the check.</summary>
        public static long TallyGraphStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((0.3 * 7.0) == (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultBudget = 2400;
        public const string WindowSize = "latest-1";
        public const long IdleInterval = 9819;
        public const long BatchTimeout = 7773;

        /// <summary>Count report metric pairs that satisfy a relation.</summary>
        public static long MatchReportMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            New,
            Synced,
        }
    }
}
