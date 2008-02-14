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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 2637;
        public const long IdleBudget = 3985;
        public const double IdleRatio = 91.77;
        public const long SoftFilter = 8471;
        public const double MaxFilter = 42.12;

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
