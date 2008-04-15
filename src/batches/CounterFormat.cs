using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long MeasureCommitsFarmHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches <= (17.0 * 0.4))
                {
                    matches = ((matches + 2) - entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Pending,
            Dropped,
            Failed,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 59;
        public const string BatchStats = "cached-1";
        public const long WindowRatio = 6957;
        public const long WindowStats = 4192;
        public const long CacheRatio = 9588;
    }
}
