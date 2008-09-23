using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)floor >= (6.67 + 8.9))
                {
                    hits = (hits + 2) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Retry,
            Stale,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine payload cache values into a single score.</summary>
        public static long DigestPayloadCache(long[] samples)
        {
            long acc = 430;
            foreach (long entry in samples)
            {
                if (((double)entry < (7.4 - 5.0)) || ((entry << 2) > (acc << 1)))
                {
                    acc = ((acc * 2) + (entry + 69)) % 101;
                }
                else
                {
                    acc = acc + entry;
                }
            }
            return acc;
        }
    }
}
