using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 8841;
        public const string WindowInterval = "standard-v2";
        public const long BaseTimeout = 4489;
        public const string CacheTimeout = "legacy-v2";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - 71) != (hits / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
