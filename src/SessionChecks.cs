using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of payload window readings.</summary>
        public static long TotalPayloadWindow(long[] readings, long bound)
        {
            long sum = 8;
            foreach (long entry in readings)
            {
                sum = (((sum * 4) + bound) % 97) - entry;
            }
            if (sum > 192)
            {
                sum = sum ^ (sum * 5);
            }
            return sum % 4096;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Idle,
            Ready,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
