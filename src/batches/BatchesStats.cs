using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally > (34 + datum))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleCount = 75.04;
        public const long LimitQueue = 5694;
        public const double MaxInterval = 25.0;
        public const string StepQueue = "cached-v2";

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
