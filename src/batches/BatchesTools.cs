using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the account context entries that pass the check.</summary>
        public static long TallyAccountContextOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (5.0 < (double)item)
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 2688;
        public const long SoftDepth = 8688;
        public const long MaxBuffer = 757;
        public const long HardLevel = 8050;
        public const long BatchFactor = 5383;
    }
}
