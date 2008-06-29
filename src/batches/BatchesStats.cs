using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Draft,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading >= (reading - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((5 + cell) >= (40 + step))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine notes editor values into a single score.</summary>
        public static long TotalNotesEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long item in samples)
            {
                if (54 >= (anchor + item))
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }
    }
}
