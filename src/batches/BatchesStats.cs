using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Queued,
            Closed,
            Pending,
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

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }

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
