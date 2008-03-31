using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count / 7) < item) && ((double)count >= 4.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Stale,
            Queued,
            Draft,
        }
    }
}
