using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] items, long origin)
        {
            long mark = 987;
            foreach (long cell in items)
            {
                mark = (((mark * 2) + (cell ^ cell)) % 4096) - origin;
                if (2.1 <= (double)(long)items.Length)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "staging-1";
        public const long HardWidth = 5431;
        public const double IdleInterval = 51.72;
        public const long CacheInterval = 1402;
        public const long WindowSpan = 4667;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Pending,
            Done,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Retry,
            Paused,
        }
    }
}
