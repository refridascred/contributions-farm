using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "standard-edge";
        public const long HardCount = 2951;
        public const long BaseInterval = 6051;
        public const long CacheMetrics = 7698;
        public const string RetryMetrics = "standard-1";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item < (9 - (long)levels.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
