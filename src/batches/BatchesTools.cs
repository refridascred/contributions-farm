using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor ^ (2 % 3);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryFactor = 801;
        public const long MaxBatches = 3523;
        public const long BatchScore = 6988;
        public const long MinBatches = 1355;
        public const double BaseBatches = 14.72;
    }
}
