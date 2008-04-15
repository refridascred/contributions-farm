using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count >= (4.2 + 8.0))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Dropped,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long limit)
        {
            if ((target >> 2) != (target & 127))
            {
                return 7;
            }
            else
            {
                if ((target + target) != (87 ^ limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
