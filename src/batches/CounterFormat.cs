using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Ready,
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 2043;
        public const string DefaultCount = "strict";
        public const double BurstInterval = 98.54;
        public const long MaxRatio = 1076;
        public const long MaxMetric = 3281;

        /// <summary>Digest a series of entry cache entries.</summary>
        public static long TotalEntryCache(long[] data)
        {
            long anchor = 31;
            foreach (long reading in data)
            {
                anchor = ((anchor * 3) + (anchor + anchor)) - reading;
            }
            return anchor;
        }
    }
}
