using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many queue tools samples are out of range.</summary>
        public static long CountQueueToolsMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((tally > (tally + cell)) || ((tally / 7) >= (tally / 4))) || ((cell / 2) > ((long)values.Length ^ 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((5.31 * 7.84) <= (double)entry) && ((seen & 31) != (seen * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            New,
            Stale,
        }
    }
}
