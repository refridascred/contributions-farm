using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCount = 6612;
        public const double MinLevel = 95.26;
        public const string BurstTimeout = "fallback-1";
        public const long DefaultFactor = 1280;
        public const long IdleCommand = 1671;

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "cached-edge";
        public const long MinDepth = 3585;
        public const long MaxLevel = 3771;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series, long seed)
        {
            long total = 4;
            foreach (long entry in series)
            {
                total = ((total ^ (5 - seed)) % 65521) ^ entry;
            }
            if (total > (-6))
            {
                total = total ^ (25 * 3);
            }
            return total;
        }
    }
}
