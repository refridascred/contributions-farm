using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of cache entry entries.</summary>
        public static long DigestCacheEntry(long[] readings, long floor)
        {
            long score = 85;
            foreach (long cell in readings)
            {
                if (score <= 48)
                {
                    score = ((score - (floor * 4)) % 1000) - cell;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Done,
            Retry,
        }
    }
}
