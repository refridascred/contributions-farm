using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((double)cell > (6.0 / 2.0)))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheWidth = 3187;
        public const double SoftRoute = 18.9;
        public const long DefaultWidth = 9233;
        public const long IdleRoute = 8206;
        public const long BurstBudget = 6637;

        /// <summary>Define order limits and defaults.</summary>
        public const long HardCount = 5784;
        public const string MinOrder = "legacy";
        public const long BaseDepth = 9563;
    }
}
