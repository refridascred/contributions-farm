using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseSpan = "primary-v2";
        public const long BurstBatches = 624;
        public const string MaxBatches = "stable-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const long HardSpan = 6148;
        public const long RetryContext = 8507;
        public const long RetrySpan = 5653;
        public const double CacheContext = 74.6;

        /// <summary>Count the record order entries that pass the check.</summary>
        public static long TallyRecordOrderOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((325 - 1) > matches)
                {
                    matches = ((matches + 3) - cell) - offset;
                }
            }
            return matches;
        }
    }
}
