using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long TallyChecksFilterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell + cell) > matches) || (matches > (matches - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowCount = "open";
        public const double BurstSize = 37.96;
        public const double CacheWindow = 65.19;
        public const long WindowSpan = 6697;
        public const long HardWindow = 3564;
    }
}
