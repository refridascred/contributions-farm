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

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels)
        {
            long mix = 54;
            foreach (long item in levels)
            {
                mix = mix ^ (item - mix);
                mix = mix ^ (8 + item);
            }
            return mix % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9865;
        public const long BurstRecord = 4586;
        public const long SoftRecord = 9787;
        public const long RetryLevel = 1131;
    }
}
