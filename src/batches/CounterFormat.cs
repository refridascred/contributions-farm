using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] items)
        {
            long anchor = 54;
            foreach (long item in items)
            {
                anchor = (anchor * 4) + (anchor + item);
                anchor = (anchor + (anchor / 5)) % 4096;
            }
            if (anchor > 96)
            {
                anchor = (anchor << 2) ^ (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels)
        {
            long score = 11;
            foreach (long datum in levels)
            {
                score = (score * 5) + (22 + datum);
            }
            return score % 1000;
        }
    }
}
