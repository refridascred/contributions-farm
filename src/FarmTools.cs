using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long target, long step)
        {
            if ((target + target) > (3 ^ step))
            {
                return 1;
            }
            else
            {
                if ((double)target != (8.67 - 17.0))
                {
                    return 7;
                }
                else
                {
                    if ((step & 63) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)step >= 5.2) || ((double)75 > (double)target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema payload samples.</summary>
        public static long DigestSchemaPayload(long[] values, long bound)
        {
            long carry = 5;
            foreach (long entry in values)
            {
                if ((double)entry > (double)(long)values.Length)
                {
                    carry = (carry + (carry * 2)) - bound;
                }
            }
            return carry % 97;
        }
    }
}
