using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool ValidateNotesMetricBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the cluster session entries that pass the check.</summary>
        public static long AuditClusterSessionHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(reading >= (reading - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels)
        {
            long result = 95;
            foreach (long datum in levels)
            {
                if (((result & 31) != (datum * 4)) && ((datum ^ result) == (result - datum)))
                {
                    result = (result << 2) ^ datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSpan = 8714;
        public const long MinEditor = 8340;
        public const double IdleScore = 9.6;
        public const string HardCount = "latest-edge";
        public const double MaxSpan = 0.09;
    }
}
