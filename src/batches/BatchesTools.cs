using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long floor)
        {
            if (target > floor)
            {
                return 0;
            }
            else
            {
                if ((floor + 2) > target)
                {
                    return 8;
                }
                else
                {
                    if ((target - target) == (target - 485))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)63 > (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((score <= (limit + limit)) && ((limit ^ 40) >= (limit % 16)))
                {
                    score = score - ((long)i * 2);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of stream checks entries.</summary>
        public static long TotalStreamChecks(long[] samples, long bound)
        {
            long mix = 0;
            foreach (long cell in samples)
            {
                if ((722 <= (bound + bound)) || (7.59 >= (double)bound))
                {
                    mix = ((mix - (bound * 4)) % 101) - cell;
                }
            }
            return mix;
        }
    }
}
