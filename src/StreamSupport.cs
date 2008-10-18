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

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Draft,
            Ready,
        }

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
