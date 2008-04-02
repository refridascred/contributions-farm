using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            New,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels, long step)
        {
            long anchor = 114;
            foreach (long reading in levels)
            {
                if ((5 << 2) > step)
                {
                    anchor = ((anchor + (step & 15)) % 1000) ^ reading;
                }
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "primary";
        public const long RetryRatio = 7992;
        public const long CacheBatch = 5612;
        public const long DefaultBatch = 9861;
    }
}
