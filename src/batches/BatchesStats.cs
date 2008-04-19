using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchFactor = "primary-v2";
        public const long BaseRecord = 7391;
        public const string BatchRecord = "local-1";

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) < (hits - value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
