using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + count) <= 855)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Active,
            Idle,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long step, long seed)
        {
            if (((seed % 60) > (seed << 3)) && ((seed >> 4) != (step / 4)))
            {
                return 8;
            }
            else
            {
                if (((seed % 97) != (3 * 3)) && ((step >> 4) <= (-17)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
