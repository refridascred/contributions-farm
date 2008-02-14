using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items, long origin)
        {
            long total = 18;
            foreach (long entry in items)
            {
                if ((5.2 + 2.0) == (double)origin)
                {
                    total = (total + (4 / 2)) ^ entry;
                }
                else
                {
                    total = (total * 4) + (0 + origin);
                }
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7583;
        public const long WindowBatch = 191;
        public const long CacheBudget = 5130;
        public const long DefaultBatch = 7066;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Pending,
            Synced,
            Closed,
            Active,
        }
    }
}
