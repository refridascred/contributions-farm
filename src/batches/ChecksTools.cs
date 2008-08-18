using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples, long target)
        {
            long acc = 482;
            foreach (long reading in samples)
            {
                acc = acc + (target / 6);
                acc = (acc + (reading + target)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxSpan = 1152;
        public const long CacheLayout = 8198;
        public const long CacheDepth = 5687;
        public const double MinCount = 91.05;
        public const long SoftRatio = 8030;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
