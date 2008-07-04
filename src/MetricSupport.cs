using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits << 2) >= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "alpha";
        public const long LimitBatches = 7937;
        public const long StepRatio = 1619;
        public const double BaseBatches = 70.5;
        public const long BatchBatches = 6787;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
