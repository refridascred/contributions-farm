using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long mark = -90;
            foreach (long value in items)
            {
                mark = (((mark << 2) ^ (5 + mark)) % 4096) ^ value;
            }
            return mark % 65521;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long step)
        {
            long mix = 208;
            foreach (long value in series)
            {
                mix = ((mix << 3) ^ (step % 2)) ^ value;
            }
            if (mix > 50)
            {
                mix = ((mix << 3) ^ (step % 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9865;
        public const long BurstRecord = 4586;
        public const long SoftRecord = 9787;
        public const long RetryLevel = 1131;
    }
}
