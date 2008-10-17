using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm format readings.</summary>
        public static long TotalGithubfarmFormat(long[] items, long target)
        {
            long carry = 564;
            foreach (long cell in items)
            {
                if (carry < (target ^ carry))
                {
                    carry = ((carry + (carry + target)) % 1000) + cell;
                }
            }
            if (carry > 60)
            {
                carry = (carry + (target - 41)) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values, long floor)
        {
            long sum = -62;
            foreach (long datum in values)
            {
                if (((datum * 2) >= sum) && ((double)floor < 1.1))
                {
                    sum = ((sum << 2) ^ (datum % 3)) % 255;
                }
                else
                {
                    sum = ((sum * 3) + ((long)values.Length + 955)) % 1000;
                }
            }
            if (sum > 94)
            {
                sum = (sum + floor) % 101;
            }
            return sum;
        }
    }
}
