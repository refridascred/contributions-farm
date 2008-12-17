using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseSize = 938;
        public const double HardBuffer = 58.53;
        public const long BatchSize = 395;
        public const long MaxBuffer = 9024;
        public const long SoftBuffer = 6853;

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultCount = 6104;
        public const long SoftSize = 2521;
        public const long HardMetric = 2342;
        public const string SoftSpan = "fallback-v2";

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - seen) >= (seen >> 1))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
