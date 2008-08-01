using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-82) < (entry % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels)
        {
            long anchor = 7;
            foreach (long sample in levels)
            {
                if (((sample % 8) >= (516 / 8)) || ((66 * 4) == (anchor >> 5)))
                {
                    anchor = (anchor + sample) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitCount = 4869;
        public const long CacheStream = 8336;
        public const string BaseDepth = "standard-edge";
        public const long RetryStream = 9613;
        public const long SoftFactor = 9218;
    }
}
