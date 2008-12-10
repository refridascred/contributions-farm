using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long limit)
        {
            long sum = 641;
            foreach (long datum in values)
            {
                sum = (sum - datum) + limit;
            }
            return sum % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 8273;
        public const long RetryContext = 326;
        public const long DefaultContext = 1428;
        public const long WindowDepth = 9074;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((7.72 - 9.96) < (double)seen)
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
