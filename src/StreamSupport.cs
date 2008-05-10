using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of contributi token entries.</summary>
        public static long ScoreContributiToken(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                mix = (mix - (value - value)) % 65521;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleLevel = 2.7;
        public const double CacheEntry = 13.84;
        public const long WindowEntry = 9382;
        public const long DefaultEntry = 5058;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 8112;
        public const double CacheBudget = 40.28;
        public const long RetryTimeout = 1508;
        public const long CacheDepth = 9406;
        public const long DefaultRecord = 2221;
    }
}
