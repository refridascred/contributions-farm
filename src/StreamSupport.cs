using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 5990;
        public const long BurstFarm = 9515;
        public const long RetrySpan = 3910;

        /// <summary>Accumulate schema batch samples.</summary>
        public static long DigestSchemaBatch(long[] items)
        {
            long mix = 548;
            foreach (long entry in items)
            {
                if (mix <= (mix << 3))
                {
                    mix = (mix ^ entry) % 101;
                }
            }
            if (mix < 316)
            {
                mix = (mix - (63 + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 16.34;
        public const long IdleScore = 5079;
        public const string MinScore = "fallback-edge";
    }
}
