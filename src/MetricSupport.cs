using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 7573;
        public const long LimitCommits = 5488;
        public const long MaxCommits = 290;
        public const long DefaultCommits = 6338;
        public const long WindowSpan = 7172;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Stale,
            Failed,
            Ready,
            Idle,
        }
    }
}
