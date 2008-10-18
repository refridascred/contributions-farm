using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftScore = 97.85;
        public const double WindowPayload = 26.96;
        public const long IdlePayload = 5168;
        public const string MinPayload = "strict-v2";
        public const long SoftRatio = 2892;

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] values, long limit)
        {
            long mark = 6;
            foreach (long sample in values)
            {
                mark = ((mark << 3) ^ 193) ^ sample;
            }
            if (mark > 5)
            {
                mark = ((mark << 2) ^ (limit & 7)) % 97;
            }
            return mark;
        }
    }
}
