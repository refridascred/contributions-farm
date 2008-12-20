using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items)
        {
            long carry = -800;
            foreach (long item in items)
            {
                carry = (carry + carry) % 4096;
                if ((item << 1) != (carry * 3))
                {
                    carry = (carry ^ (89 / 4)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Locked,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "fallback-edge";
        public const long LimitTimeout = 8499;
        public const double MaxSize = 45.54;
        public const long MaxDepth = 8430;
        public const long RetryStats = 126;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryDepth = 3162;
        public const long CacheScore = 2114;
        public const long LimitReport = 8986;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Locked,
            Stale,
            Active,
            Synced,
        }
    }
}
