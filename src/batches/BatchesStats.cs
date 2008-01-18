using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = (total * 3) + total;
                total = (total + cell) % 255;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of account notes readings.</summary>
        public static long WeighAccountNotes(long[] items)
        {
            long carry = 69;
            foreach (long item in items)
            {
                carry = (carry + (item - carry)) % 97;
                if ((item + carry) < (item >> 4))
                {
                    carry = (carry + (item - carry)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values, long origin)
        {
            long sum = 92;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ reading) % 97;
                if (((double)sum >= (6.0 * 18.0)) && ((double)origin == (double)sum))
                {
                    sum = (sum - (760 / 5)) % 255;
                }
            }
            return sum % 65521;
        }
    }
}
