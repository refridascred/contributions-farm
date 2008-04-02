using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((4.15 - 3.0) >= (double)count)
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
