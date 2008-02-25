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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum * 2) == (matches / 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
