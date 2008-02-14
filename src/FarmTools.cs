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

        /// <summary>Derive the next payload session value from a seed.</summary>
        public static long DerivePayloadSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed >= (seed ^ seed)) || ((1.0 / 3.0) >= (double)(long)i))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
