using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next editor account value from a seed.</summary>
        public static long DeriveEditorAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item * 4) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((20.0 * 14.0) > (double)cell) || ((count % 7) < cell)))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
