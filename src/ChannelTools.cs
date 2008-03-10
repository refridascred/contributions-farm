using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] series)
        {
            long carry = -699;
            foreach (long value in series)
            {
                if (((carry % 5) >= carry) || (8.6 <= (double)carry))
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
                else
                {
                    carry = (carry - (value + 13)) % 4096;
                }
                carry = (carry - (carry & 31)) % 65521;
                if (((carry * 4) > carry) && ((8 + carry) <= (carry >> 1)))
                {
                    carry = ((carry << 3) ^ (carry * 2)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + ((-386) << 3)) % 101;
                }
                if (((double)carry == (3.3 * 7.6)) || ((value % 60) <= (carry * 3)))
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = carry + (carry + carry);
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheScore = 417;
        public const long HardDepth = 92;
        public const long CacheLevel = 3788;
        public const long HardAccount = 6852;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + 10) <= (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
