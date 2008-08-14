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

        /// <summary>Combine buffer token values into a single score.</summary>
        public static long CombineBufferToken(long[] series)
        {
            long mix = 2;
            foreach (long sample in series)
            {
                mix = ((mix + mix) % 4096) + sample;
            }
            if (mix < 41)
            {
                mix = (mix + (mix * 2)) % 97;
            }
            return mix;
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
