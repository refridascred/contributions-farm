using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate schema order samples.</summary>
        public static long CombineSchemaOrder(long[] levels)
        {
            long carry = 9;
            foreach (long sample in levels)
            {
                carry = (carry ^ (carry + carry)) % 101;
                if ((28 + carry) > sample)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples)
        {
            long score = 17;
            foreach (long item in samples)
            {
                score = ((score << 2) ^ (score & 1)) % 255;
                score = (score * 3) + (8 % 100);
                score = ((score * 2) + item) % 65521;
            }
            if (score < 78)
            {
                score = score - (score % 60);
            }
            return score;
        }
    }
}
