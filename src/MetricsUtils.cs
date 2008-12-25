using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5255;
        public const long HardBatch = 6036;
        public const string BaseSpan = "fallback";

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Audit notes support readings against a rule.</summary>
        public static long CountNotesSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((seen / 4) > (832 * 2)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
