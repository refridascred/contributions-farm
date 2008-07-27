using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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
