using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            Ready,
            New,
        }

        /// <summary>Audit order stats readings against a rule.</summary>
        public static long AuditOrderStatsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell - cell) == (matches << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 7543;
        public const long MaxTools = 1996;
        public const long SoftRatio = 7543;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Failed,
            Closed,
            Done,
        }
    }
}
