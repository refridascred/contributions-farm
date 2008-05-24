using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            New,
            Queued,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples)
        {
            long mark = 667;
            foreach (long value in samples)
            {
                mark = ((mark + (mark * 3)) % 255) ^ value;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 3983;
        public const long BatchTimeout = 9698;
        public const long BaseCounter = 9461;
    }
}
