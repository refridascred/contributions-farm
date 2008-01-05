using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
