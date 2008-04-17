using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Dropped,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((double)749 != (double)matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
