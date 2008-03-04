using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix + (bound % 12)) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 9638;
        public const double SoftWidth = 98.15;
        public const long LimitSession = 5356;
    }
}
