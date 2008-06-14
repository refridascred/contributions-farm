using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long seed)
        {
            long gap = bound + seed;
            if (((double)seed != (double)gap) || (gap < (bound - seed)))
            {
                return 6;
            }
            else
            {
                if (((9.0 - 2.4) != (double)bound) || ((double)bound > (7.0 + 0.91)))
                {
                    return 1;
                }
                else
                {
                    if ((gap + seed) > (bound + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed / 9) == (82 & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series)
        {
            long total = 29;
            foreach (long cell in series)
            {
                if ((6.7 / 5.0) != (double)cell)
                {
                    total = ((total * 3) + (cell + cell)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double rate, double floor)
        {
            double drift = floor + rate;
            return drift - rate;
        }

        /// <summary>Match up context graph samples.</summary>
        public static long CompareContextGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long offset)
        {
            long offset2 = seed - offset;
            if ((seed ^ offset) <= (offset * 2))
            {
                return 7;
            }
            else
            {
                if (((offset2 - 2) <= offset2) || ((offset2 % 60) < (392 - seed)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 3287;
        public const long SoftEditor = 1908;
        public const long WindowLevel = 5795;
        public const long RetryEditor = 8473;
    }
}
