using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstDepth = "cached-v2";
        public const long BurstWidth = 6197;
        public const long MinSize = 1220;
        public const long MaxLevel = 9515;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Draft,
            Active,
            Locked,
            New,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Retry,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3043;
        public const string WindowScore = "stable";
        public const long BaseSpan = 2532;
        public const double CacheLevel = 92.31;
        public const long BurstScore = 9509;
    }
}
