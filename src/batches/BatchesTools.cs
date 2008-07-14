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

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long limit, long target)
        {
            if ((target + target) <= (target + limit))
            {
                return 5;
            }
            else
            {
                if ((target << 3) != (target * 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)target < 6.42)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
