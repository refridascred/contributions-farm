using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 3098;
        public const long BurstCommand = 8212;
        public const long LimitCommand = 478;

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long MeasureGraphFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((((long)items.Length % 12) >= hits) && ((double)hits == (double)hits)) && ((double)hits > (double)cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
