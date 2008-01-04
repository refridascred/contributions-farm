using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long step, long floor)
        {
            if (5.7 <= (double)floor)
            {
                return 1;
            }
            else
            {
                if (step < (step - step))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((17.0 > (double)seed) && !((cell + seed) == (cell & 15)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
