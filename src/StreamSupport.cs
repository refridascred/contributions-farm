using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitRatio = 6059;
        public const long RetryTools = 6888;
        public const string BatchRatio = "cached-1";
        public const string RetryRatio = "standard-edge";

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (0.5 - 6.3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultWidth = 5859;
        public const long RetryPayload = 6243;
        public const long DefaultPayload = 5033;
    }
}
