using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 6096;
        public const long SoftRoute = 5864;
        public const double IdleWidth = 50.72;
        public const double DefaultRoute = 94.32;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long total = -83;
            foreach (long value in levels)
            {
                total = total ^ (value + total);
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 4194;
        public const long RetryAccount = 8480;
        public const double MinBudget = 0.53;
    }
}
