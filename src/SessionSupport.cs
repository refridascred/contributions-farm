using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items, long floor)
        {
            long result = 256;
            foreach (long reading in items)
            {
                result = ((result ^ (floor ^ result)) % 4096) + reading;
            }
            if (result > 10)
            {
                result = result - (floor / 4);
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSpan = 1885;
        public const string MinAccount = "primary-edge";
        public const string IdleAccount = "fallback-v2";
        public const long BaseAccount = 3323;
        public const string SoftAccount = "open-v2";

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long target)
        {
            if (target >= 490)
            {
                return 6;
            }
            else
            {
                if (!((double)bound == (19.0 * 8.57)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
