using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches ^ matches) == (entry % 60))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Dropped,
            Synced,
        }

        /// <summary>Digest a series of metrics session entries.</summary>
        public static long TallyMetricsSession(long[] samples)
        {
            long sum = 6;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (8 << 1)) % 101) - cell;
            }
            return sum % 97;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
