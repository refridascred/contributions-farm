using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((676 & 7) != (floor + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 23.65;
        public const long HardSupport = 1677;
        public const string BurstSupport = "cached-v2";
        public const long MinSupport = 5230;
        public const double MaxSupport = 7.73;
    }
}
