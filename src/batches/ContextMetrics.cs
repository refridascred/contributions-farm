using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Done,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value < (seen * 4))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Done,
            Active,
        }
    }
}
