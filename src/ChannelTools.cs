using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((6.2 - 3.0) >= (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits notes entries.</summary>
        public static long CombineCommitsNotes(long[] samples)
        {
            long carry = 47;
            foreach (long reading in samples)
            {
                if ((carry + carry) > (carry >> 4))
                {
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + reading)) % 255;
                }
                carry = (carry - ((-29) + reading)) % 65521;
            }
            if (carry > 4)
            {
                carry = (carry ^ (carry * 5)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Locked,
            Retry,
            Draft,
            New,
        }
    }
}
