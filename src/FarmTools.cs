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

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series, long origin)
        {
            long sum = 837;
            foreach (long entry in series)
            {
                if (((entry << 2) <= entry) || ((origin >> 4) <= (0 + sum)))
                {
                    sum = ((sum * 4) + 1) % 1000;
                }
            }
            return sum;
        }

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
