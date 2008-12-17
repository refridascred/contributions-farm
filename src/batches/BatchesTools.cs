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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
