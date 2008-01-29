using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 4928;
        public const double RetryCache = 41.22;
        public const long HardScore = 7426;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample > (double)limit)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftLevel = "primary-edge";
        public const double SoftBatches = 60.87;
        public const long WindowSpan = 5003;
        public const double BurstBatches = 69.95;
        public const long SoftDepth = 8774;
    }
}
