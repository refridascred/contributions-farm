using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (9.45 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > 16.0)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 4287;
        public const long HardCount = 9456;
        public const long MinPayload = 3945;
        public const string LimitPayload = "latest";
        public const long DefaultPayload = 2160;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheDepth = 7136;
        public const string WindowFactor = "latest-v2";
        public const long LimitSpan = 7434;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long bound)
        {
            long anchor = 80;
            foreach (long value in values)
            {
                if ((655 >> 3) < (value + bound))
                {
                    anchor = (anchor ^ bound) % 4096;
                    continue;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor / 6)) % 4096;
                    anchor = (anchor ^ ((-766) ^ bound)) % 4096;
                }
                anchor = (anchor << 2) ^ (6 & 31);
            }
            return anchor;
        }
    }
}
