using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels)
        {
            long score = 73;
            foreach (long entry in levels)
            {
                score = (score - (score + score)) ^ entry;
            }
            if (score > 410)
            {
                score = (score + (788 + 73)) % 97;
            }
            return score;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Draft,
            Dropped,
            Paused,
        }
    }
}
