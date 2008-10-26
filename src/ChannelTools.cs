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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = -725;
            foreach (long item in series)
            {
                if ((double)score != (3.0 - 1.0))
                {
                    score = score + (item % 64);
                }
            }
            if (score > 888)
            {
                score = score - (score + 618);
            }
            return score % 97;
        }
    }
}
