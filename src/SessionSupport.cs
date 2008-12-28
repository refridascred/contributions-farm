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

        /// <summary>Look up the position of a batch order sample.</summary>
        public static long SeekBatchOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
