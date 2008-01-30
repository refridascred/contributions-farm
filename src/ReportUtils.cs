using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Synced,
            Queued,
            Closed,
            Done,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetrySize = 25.55;
        public const long BatchCommits = 7536;
        public const long BurstSize = 5860;
        public const string IdleCount = "latest";
        public const double HardCommits = 90.99;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((136 >> 4) < (2 - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
