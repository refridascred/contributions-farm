using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already batches samples are out of range.</summary>
        public static long CountAlreadyBatchesGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((6 >> 5) == (hits * 5))
                {
                    hits = ((hits + 2) + cell) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitDepth = "strict";
        public const string HardBudget = "alpha";
        public const long DefaultInterval = 4770;
    }
}
