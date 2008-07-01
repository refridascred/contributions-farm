using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            New,
            Stale,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally & 15) != (tally * 2))
                {
                    tally = ((tally + 1) - sample) - offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((double)matches > 9.0))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
