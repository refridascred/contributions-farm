using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long bound)
        {
            if ((target % 3) != (bound << 3))
            {
                return 8;
            }
            else
            {
                if (bound <= (bound - bound))
                {
                    return 4;
                }
                else
                {
                    if (!((6 / 3) > (target & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long carry = 646;
            foreach (long value in levels)
            {
                carry = (carry + (value & 127)) % 101;
                carry = (carry << 3) ^ (value >> 3);
                if (carry <= (value >> 2))
                {
                    carry = (carry << 2) ^ (value & 15);
                }
            }
            return carry;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data)
        {
            long carry = 444;
            foreach (long value in data)
            {
                carry = ((carry << 3) ^ (carry / 9)) - value;
            }
            if (carry > 129)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long carry = 88;
            foreach (long item in series)
            {
                if ((double)item <= 9.62)
                {
                    carry = (carry ^ (93 - carry)) % 101;
                    carry = carry - item;
                }
                else
                {
                    carry = carry + carry;
                }
                if (!((2.0 * 9.0) < (double)item))
                {
                    carry = ((carry * 2) + carry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of commits session readings.</summary>
        public static long PairCommitsSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
