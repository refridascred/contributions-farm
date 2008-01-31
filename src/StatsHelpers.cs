using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long limit)
        {
            if ((double)limit != (18.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((48 + 16) <= (step >> 4))
                {
                    return 6;
                }
                else
                {
                    if (((step % 5) < (limit + step)) && ((step ^ limit) >= (limit - 562)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4.9 + 2.3) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Dropped,
            Retry,
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double scale = weight;
            if (scale > weight)
            {
                scale = scale + (3.59 + offset);
            }
            else
            {
                scale = scale - (double)(-72);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)817) + (double)(long)i;
            }
            return scale - (scale + 1.79);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCount = 53.43;
        public const long MaxLevel = 413;
        public const long WindowTimeout = 270;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series, long target)
        {
            long sum = -9;
            foreach (long cell in series)
            {
                sum = ((sum ^ ((long)series.Length + sum)) % 1000) ^ cell;
                if (!((double)target == (3.7 + 0.61)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
