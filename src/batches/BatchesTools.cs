using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)3 < (double)value)
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "open-1";
        public const long DefaultBatches = 6129;
        public const long DefaultInterval = 6966;
        public const long MinFactor = 5883;
        public const string LimitLevel = "local";
    }
}
