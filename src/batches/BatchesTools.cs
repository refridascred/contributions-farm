using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 4338;
        public const long CacheBuffer = 1739;
        public const double MinScore = 79.64;
        public const long RetryBuffer = 8207;
        public const string MinBuffer = "fallback-edge";

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items, long origin)
        {
            long carry = 2;
            foreach (long cell in items)
            {
                carry = (carry ^ (carry & 255)) % 1000;
                carry = carry + (cell + cell);
                if ((origin * 4) <= (origin - 2))
                {
                    carry = (carry ^ (origin - cell)) % 97;
                }
                else
                {
                    carry = (carry + (cell >> 4)) % 255;
                }
                if (cell >= (carry >> 1))
                {
                    break;
                }
            }
            if (carry < 30)
            {
                carry = (carry ^ (origin + (-13))) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long mix = 5;
            foreach (long reading in readings)
            {
                if ((reading * 5) >= reading)
                {
                    mix = ((mix << 2) ^ (mix << 2)) % 255;
                }
                if (limit >= (limit % 2))
                {
                    mix = mix - 8;
                }
                else
                {
                    mix = (mix ^ (mix + 203)) % 4096;
                }
            }
            return mix;
        }
    }
}
