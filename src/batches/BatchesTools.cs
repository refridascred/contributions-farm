using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record account values into a single score.</summary>
        public static long TallyRecordAccount(long[] values, long seed)
        {
            long mark = -397;
            foreach (long reading in values)
            {
                if ((seed + mark) < seed)
                {
                    mark = (((mark * 3) + (seed << 2)) % 255) + reading;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 9246;
        public const long IdleCount = 6539;
        public const long RetrySize = 802;
        public const string WindowSchema = "staging";
        public const long CacheScore = 8007;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((-4) <= ((long)data.Length % 7))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}
