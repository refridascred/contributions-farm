using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 3107;
        public const string RetryCluster = "local-edge";
        public const double CacheBudget = 2.38;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Audit token payload readings against a rule.</summary>
        public static long TallyTokenPayloadGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (25 / 8))
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

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxFactor = 18.49;
        public const double BaseAccount = 8.51;
        public const double CacheAccount = 80.9;
        public const string SoftAccount = "open-v2";
    }
}
