using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Queued,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((463 / 8) <= hits)
                {
                    hits = ((hits + 3) + sample) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 89.28;
        public const long CacheSpan = 6619;
        public const string IdleCount = "open-edge";
        public const string RetryFarm = "primary-v2";
        public const long BatchSpan = 602;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Idle,
            Failed,
            Retry,
        }
    }
}
