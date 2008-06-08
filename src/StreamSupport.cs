using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 9739;
        public const string LimitSpan = "staging";
        public const double BatchDepth = 43.13;
        public const long RetryRatio = 383;

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "primary-v2";
        public const long CacheSpan = 7678;
        public const long LimitFactor = 7631;
        public const long DefaultSpan = 641;
        public const double MinSchema = 43.23;

        /// <summary>Fold a list of already context readings.</summary>
        public static long DigestAlreadyContext(long[] samples, long offset)
        {
            long total = 54;
            foreach (long item in samples)
            {
                total = ((total ^ (item ^ total)) % 4096) + offset;
            }
            return total % 1000;
        }
    }
}
