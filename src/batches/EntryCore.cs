using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "staging";
        public const long CacheWindow = 5651;
        public const long MinScore = 8925;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((559 - 52) <= (reading & 7))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Audit editor support readings against a rule.</summary>
        public static long CountEditorSupportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading * 4) <= tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long limit)
        {
            long total = 119;
            foreach (long entry in values)
            {
                total = ((total ^ limit) % 97) + entry;
            }
            if (total < (-91))
            {
                total = (total + (total % 24)) % 101;
            }
            return total;
        }
    }
}
