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

        /// <summary>Validate contributi already readings against a bound.</summary>
        public static bool GuardContributiAlreadyLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
