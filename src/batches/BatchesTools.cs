using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window context samples are out of range.</summary>
        public static long CountWindowContextHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (0 > entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6017;
        public const long BurstDepth = 7182;
        public const long CacheReport = 8403;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
