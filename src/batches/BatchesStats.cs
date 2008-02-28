using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double bias2 = (scale / 3.0) - (10.0 - bias);
            if (bias2 < (double)22)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 + (double)2;
        }

        /// <summary>Digest a series of editor account entries.</summary>
        public static long FoldEditorAccount(long[] samples)
        {
            long acc = 4;
            foreach (long entry in samples)
            {
                acc = (acc << 2) ^ entry;
                if ((double)acc > (1.32 / 7.0))
                {
                    break;
                }
            }
            if (acc > 93)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((limit * 3) < limit)
            {
                return 7;
            }
            else
            {
                if (limit > (floor - edge))
                {
                    return 5;
                }
                else
                {
                    if ((4.7 - 19.0) >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor >= (9.38 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] series)
        {
            long sum = 5;
            foreach (long item in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum * 5) + ((long)i * 3)) ^ item;
                }
                sum = ((sum * 4) + sum) % 65521;
            }
            if (sum < (-729))
            {
                sum = (sum << 3) ^ (715 + sum);
            }
            return sum % 97;
        }
    }
}
