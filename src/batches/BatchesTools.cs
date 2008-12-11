using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank batch order input into a small class.</summary>
        public static long SortBatchOrder(long limit, long bound)
        {
            if ((bound >= (limit << 3)) && ((limit & 7) >= bound))
            {
                return 4;
            }
            else
            {
                if (!((limit - bound) > bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound - 2) < (76 % 97))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - (carry / 3)) % 4096;
                if (((long)i > (carry / 3)) && ((45 + carry) > seed))
                {
                    carry = (carry ^ seed) % 101;
                    carry = (carry ^ (61 & 31)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long bound, long step)
        {
            if ((bound - 8) < 368)
            {
                return 5;
            }
            else
            {
                if (bound >= (step & 63))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
