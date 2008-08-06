using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - matches) == (matches << 3))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 2359;
        public const long LimitMetrics = 2056;
        public const long BaseScore = 538;
        public const long IdleMetrics = 7038;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ 406) % 65521;
                mark = ((mark << 2) ^ (seed * 4)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            New,
            Done,
        }

        /// <summary>Accumulate profile tools samples.</summary>
        public static long FoldProfileTools(long[] readings, long origin)
        {
            long mark = 18;
            foreach (long sample in readings)
            {
                mark = ((mark << 3) ^ (sample << 2)) + origin;
            }
            return mark % 65521;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Pending,
            Closed,
            Done,
        }
    }
}
