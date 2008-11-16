using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseSpan = 5224;
        public const long MinChecks = 4656;
        public const long CacheDepth = 5972;

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleSpan = "primary-edge";
        public const long BatchOrder = 3788;
        public const string CacheSpan = "alpha";

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((hits * 5) > (reading >> 4)) && ((reading - hits) <= (reading * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
