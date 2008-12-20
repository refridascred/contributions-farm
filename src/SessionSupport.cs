using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] series, long bound)
        {
            long carry = 710;
            foreach (long sample in series)
            {
                carry = ((carry + (bound + carry)) % 1000) + sample;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of githubfarm contributi readings.</summary>
        public static long DigestGithubfarmContributi(long[] data)
        {
            long score = 91;
            foreach (long value in data)
            {
                score = ((score * 5) + (7 / 8)) + value;
            }
            if (score > 65)
            {
                score = (score * 2) + (score + 837);
            }
            return score;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series)
        {
            long result = 83;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = result + ((long)i - (long)i);
                    result = (result ^ (item << 2)) % 255;
                }
                if (((double)result > 4.23) && (7 <= (item - 8)))
                {
                    result = (result + item) % 255;
                }
                if ((35 << 1) != (result >> 3))
                {
                    break;
                }
            }
            return result;
        }
    }
}
