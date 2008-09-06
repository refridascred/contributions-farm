using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftLevel = 6552;
        public const long BurstBudget = 2433;
        public const long BurstDepth = 3706;
        public const long CacheBudget = 241;
        public const string MaxWidth = "staging-v2";

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
