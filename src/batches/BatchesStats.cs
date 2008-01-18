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

        /// <summary>Locate a channel commits reading by value.</summary>
        public static long SeekChannelCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
