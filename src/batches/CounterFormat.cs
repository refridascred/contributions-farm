using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally << 1) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Locked,
            Queued,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Synced,
            Idle,
            Stale,
            New,
        }
    }
}
