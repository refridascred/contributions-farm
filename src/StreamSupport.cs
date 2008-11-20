using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the stats payload entries that pass the check.</summary>
        public static long AuditStatsPayloadHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - value) < (seen + bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
