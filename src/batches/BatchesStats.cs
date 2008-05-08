using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values)
        {
            long total = 53;
            foreach (long entry in values)
            {
                if (entry >= (entry >> 5))
                {
                    total = (total ^ entry) % 101;
                }
            }
            if (total > 57)
            {
                total = ((total * 3) + (7 ^ 42)) % 1000;
            }
            return total;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (seed + carry);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 3889;
        public const double LimitScore = 11.49;
        public const long LimitSupport = 29;
    }
}
