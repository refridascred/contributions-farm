using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 8.02;
        public const long RetryBatch = 9455;
        public const long SoftBatch = 2349;
        public const double MaxCount = 59.16;

        /// <summary>Derive the next metrics counter value from a seed.</summary>
        public static long DeriveMetricsCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((anchor - offset) > 846)
                {
                    anchor = ((anchor << 2) ^ (anchor * 4)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
