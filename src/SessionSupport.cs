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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (step & 15)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
