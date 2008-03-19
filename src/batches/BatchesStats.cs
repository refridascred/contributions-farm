using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (!((bound2 << 3) < bound2))
            {
                return 7;
            }
            else
            {
                if ((50 & 63) == (bound ^ offset))
                {
                    return 5;
                }
                else
                {
                    if (!((3.49 * 13.0) == (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound2 >= (offset + 18))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double weight, double bias)
        {
            double gain = (3.0 / 4.0) + (3.08 + bias);
            if (gain >= weight)
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain - (bias / 3.0);
            }
            return gain + bias;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double offset)
        {
            double scale = (double)(29 ^ 2);
            return ((scale + scale) + bias) + offset;
        }
    }
}
