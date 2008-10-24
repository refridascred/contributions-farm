using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardScore = 2857;
        public const double BurstSpan = 89.38;
        public const long IdleScore = 5649;
        public const string LimitSpan = "stable-1";

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((2 + value) >= (count + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
