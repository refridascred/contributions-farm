using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell < 59)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Done,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Synced,
            Done,
            Active,
            Draft,
        }
    }
}
