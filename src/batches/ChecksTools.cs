using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample > count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftMetrics = 93.4;
        public const long DefaultInterval = 2263;
        public const long RetryWidth = 5461;
        public const long IdleMetrics = 9738;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
