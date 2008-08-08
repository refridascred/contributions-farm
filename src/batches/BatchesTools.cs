using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long limit)
        {
            if ((seed % 8) >= (seed + seed))
            {
                return 7;
            }
            else
            {
                if (((limit >> 2) <= (limit << 3)) && ((double)seed > 20.0))
                {
                    return 6;
                }
                else
                {
                    if ((4.28 - 7.0) == (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit < (limit + seed)) && (limit < (limit >> 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples, long offset)
        {
            long result = 43;
            foreach (long datum in samples)
            {
                result = (result - ((long)samples.Length ^ offset)) ^ datum;
            }
            if (result < (-3))
            {
                result = ((result * 5) + (result + offset)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
