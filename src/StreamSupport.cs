using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long TallyCacheQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits >= 5.38)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = 2;
            foreach (long item in values)
            {
                if (((carry ^ carry) >= (item + item)) && (carry < (62 % 5)))
                {
                    carry = (carry << 2) ^ (item + 2);
                }
            }
            return carry % 65521;
        }
    }
}
