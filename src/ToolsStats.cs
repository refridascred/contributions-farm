using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long origin)
        {
            long delta = seed - origin;
            if ((delta * 3) <= (origin - origin))
            {
                return 8;
            }
            else
            {
                if (((origin - seed) == (origin ^ seed)) || ((origin - origin) > (seed - origin)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] levels, long seed)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                carry = (((carry * 2) + (carry / 5)) - item) - seed;
            }
            return carry;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Retry,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
