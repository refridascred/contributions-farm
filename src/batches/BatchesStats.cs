using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a account channel counter forward.</summary>
        public static long DeriveAccountChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (long)i) % 97;
                carry = (carry - (limit / 8)) % 65521;
                carry = (carry + (carry << 1)) % 1000;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items)
        {
            long mix = 923;
            foreach (long cell in items)
            {
                if (((mix >> 5) <= (cell >> 2)) || (0.1 <= (8.13 * 1.0)))
                {
                    mix = mix ^ (5 << 1);
                }
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheDepth = 449;
        public const string StepInterval = "staging-v2";
        public const string LimitCount = "legacy-edge";
        public const long IdleInterval = 2936;
        public const long IdleFactor = 289;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Active,
            Done,
        }
    }
}
