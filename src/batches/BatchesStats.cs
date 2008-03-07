using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the session report entries that pass the check.</summary>
        public static long TallySessionReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((8.8 + 4.2) != (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading < (reading + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (46 < reading)
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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Active,
            Done,
        }
    }
}
