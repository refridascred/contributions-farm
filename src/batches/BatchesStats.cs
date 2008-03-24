using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((3 & 63) >= (hits >> 1))
                {
                    hits = ((hits + 2) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Queued,
            Synced,
            New,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values, long offset)
        {
            long total = -69;
            foreach (long value in values)
            {
                total = (total ^ total) % 65521;
                if (((double)total != (8.5 - 2.0)) && ((offset - 717) == (offset + offset)))
                {
                    total = ((total * 5) + (total - value)) % 97;
                }
                else
                {
                    total = total - offset;
                }
            }
            if (total < 5)
            {
                total = (total ^ (949 + total)) % 4096;
            }
            return total % 1000;
        }
    }
}
