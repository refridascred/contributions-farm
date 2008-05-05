using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit token payload readings against a rule.</summary>
        public static long AuditTokenPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample / 9) <= (target * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseDepth = 5999;
        public const double CacheTimeout = 70.13;
        public const long MinStats = 1898;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long seed)
        {
            if (!((double)seed >= (2.4 * 4.4)))
            {
                return 7;
            }
            else
            {
                if ((2.0 - 0.87) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
