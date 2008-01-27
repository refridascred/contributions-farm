using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the notes channel entries that pass the check.</summary>
        public static long AuditNotesChannelMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((587 - matches) <= (64 % 60))
                {
                    matches = ((matches + 1) ^ value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepSpan = 65.04;
        public const long MinStats = 6070;
        public const long LimitStats = 9484;
    }
}
