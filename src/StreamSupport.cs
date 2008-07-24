using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the token order series from a seed.</summary>
        public static long DeriveTokenOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                if (!((carry * 3) < carry))
                {
                    carry = ((carry ^ (1 << 1)) % 255) + reading;
                }
                else
                {
                    carry = carry - 8;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank commits editor input into a small class.</summary>
        public static long RankCommitsEditor(long limit, long target)
        {
            if (((target & 7) > target) || ((96 - limit) >= (target ^ target)))
            {
                return 7;
            }
            else
            {
                if ((limit >> 5) == (target & 127))
                {
                    return 4;
                }
                else
                {
                    if ((target / 6) > (limit / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-65) << 1) < (limit + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
