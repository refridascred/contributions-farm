using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit report tools readings against a rule.</summary>
        public static long TallyReportToolsMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally >> 4) <= (seed - 71))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits + cell) != (cell ^ cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
