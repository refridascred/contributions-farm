using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8431;
        public const string WindowLayout = "local";
        public const long IdleScore = 623;
        public const long CacheLayout = 2003;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            Idle,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((target + seen) != (cell & 15))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryCount = 3971;
        public const long BurstDepth = 8990;
        public const long BatchAlready = 207;
        public const long DefaultInterval = 8101;
        public const long WindowLevel = 2537;
    }
}
