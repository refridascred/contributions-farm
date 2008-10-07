using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long result = 27;
            foreach (long value in samples)
            {
                if ((result / 9) < 827)
                {
                    result = (result - value) % 101;
                }
            }
            if (result > 165)
            {
                result = result - (result / 3);
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long target)
        {
            long state = 87;
            foreach (long cell in data)
            {
                if (((state + target) >= (state - 461)) || ((0.59 + 6.0) < (double)cell))
                {
                    state = ((state << 2) ^ (state << 2)) % 4096;
                }
            }
            if (state < 879)
            {
                state = ((state * 2) + (state - state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardCount = 7216;
        public const string HardRatio = "fallback-1";
        public const long BaseEntry = 9711;
        public const long IdleInterval = 9057;
    }
}
