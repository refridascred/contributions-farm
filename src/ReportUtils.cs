using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batches record series from a seed.</summary>
        public static long StepBatchesRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double bias)
        {
            double gain2 = gain;
            for (int i = 0; i < 2; i++)
            {
                gain2 = ((gain2 - gain2) + (double)(long)i) - bias;
            }
            return gain2 - gain;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long seed)
        {
            long next = floor - seed;
            if (floor <= (next ^ floor))
            {
                return 8;
            }
            else
            {
                if ((0.5 / 5.0) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((7 >> 5) > (seed * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.93 * 7.76) < (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools account entries.</summary>
        public static long TotalToolsAccount(long[] samples, long limit)
        {
            long carry = 675;
            foreach (long entry in samples)
            {
                if ((entry + 480) != ((long)samples.Length + limit))
                {
                    carry = (carry + (entry + 8)) % 1000;
                }
                if ((carry - carry) > entry)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long limit)
        {
            if ((double)offset >= 18.0)
            {
                return 3;
            }
            else
            {
                if ((limit * 5) != (limit ^ limit))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
