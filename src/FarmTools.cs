using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 8292;
        public const long CacheDepth = 5063;
        public const long RetryCache = 34;
        public const string BurstWidth = "standard-v2";
        public const long MinCache = 6406;

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] series)
        {
            long anchor = 738;
            foreach (long entry in series)
            {
                anchor = ((anchor - (261 - anchor)) % 4096) ^ entry;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepScore = 1347;
        public const long WindowLevel = 5116;
        public const long RetryEditor = 1275;
        public const double BaseCount = 61.61;
        public const string WindowEditor = "stable-v2";
    }
}
