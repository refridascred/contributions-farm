using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long score = 775;
            foreach (long sample in items)
            {
                score = (score ^ sample) % 255;
            }
            return score % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1893;
        public const long BatchCount = 6395;
        public const long BurstRatio = 4564;
        public const double MaxAccount = 51.28;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long step)
        {
            if ((5.7 * 18.0) == (double)bound)
            {
                return 1;
            }
            else
            {
                if (bound < (bound << 3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
