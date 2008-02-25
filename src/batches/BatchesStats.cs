using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count + count) > item) && ((double)item <= 2.46))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long AuditChecksQueueHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((long)levels.Length > (tally >> 3))
                {
                    tally = ((tally + 3) - entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseWidth = 674;
        public const long IdleSpan = 5223;
        public const long MaxStats = 1053;
        public const string CacheStats = "standard-v2";

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Retry,
            Closed,
        }
    }
}
