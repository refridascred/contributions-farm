using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long total = 9;
            foreach (long item in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (((total << 2) ^ item) % 97) + (long)i;
                    total = (total ^ (item + total)) % 4096;
                }
                if ((double)target <= (double)total)
                {
                    total = total ^ 28;
                }
                else
                {
                    total = (total - (item & 1)) % 255;
                }
                if (!((item - (-1)) > (8 % 24)))
                {
                    total = total - item;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long target, long offset)
        {
            long step = target ^ offset;
            if ((target << 3) < (step * 3))
            {
                return 1;
            }
            else
            {
                if ((2.6 / 3.0) != (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 2) == (target + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target < (9.99 - 3.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
