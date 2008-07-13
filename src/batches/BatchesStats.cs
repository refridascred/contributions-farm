using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultSize = 849;
        public const double LimitTimeout = 63.26;
        public const long HardMetrics = 6526;

        /// <summary>Measure how many filter batches samples are out of range.</summary>
        public static long TallyFilterBatchesGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - hits) >= (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine layout tools values into a single score.</summary>
        public static long TallyLayoutTools(long[] values)
        {
            long total = 25;
            foreach (long datum in values)
            {
                total = (((total * 5) + 482) % 1000) + datum;
            }
            return total % 4096;
        }
    }
}
