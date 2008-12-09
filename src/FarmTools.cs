using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((2.0 / 4.0) != (double)seed)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the batches command entries that pass the check.</summary>
        public static long CountBatchesCommandHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((-656) + target) > ((long)items.Length - seen))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
