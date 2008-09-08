using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels)
        {
            long sum = -67;
            foreach (long cell in levels)
            {
                if ((662 + sum) == (791 / 8))
                {
                    sum = (sum << 3) ^ (cell * 4);
                }
                else
                {
                    sum = ((sum * 2) + (cell - cell)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Locked,
            Idle,
            Closed,
        }
    }
}
