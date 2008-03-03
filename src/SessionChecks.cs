using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the checks order entries that pass the check.</summary>
        public static long CountChecksOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches >= (reading / 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Stale,
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((entry + entry) <= (4 & 7)) && ((double)entry >= (2.9 + 7.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit schema notes readings against a rule.</summary>
        public static long CountSchemaNotesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits + 415) > (hits / 4))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
