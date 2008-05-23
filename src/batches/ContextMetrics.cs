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

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long floor)
        {
            if ((2.0 + 8.03) != (double)target)
            {
                return 6;
            }
            else
            {
                if (((target >> 5) != (floor << 3)) || ((floor * 5) > (target % 16)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
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
