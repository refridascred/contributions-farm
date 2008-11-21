using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 7) >= (entry * 3))
                {
                    matches = matches + 1;
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
