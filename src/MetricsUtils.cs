using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((30 + reading) < (bound + reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long MeasureStreamPayloadGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches - matches) < (bound * 3))
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
