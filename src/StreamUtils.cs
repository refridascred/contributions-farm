using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples, long limit)
        {
            long sum = 54;
            foreach (long item in samples)
            {
                if ((9.8 - 7.2) > (double)item)
                {
                    sum = (sum + (item + item)) % 255;
                }
            }
            if (sum < 1)
            {
                sum = ((sum * 3) + limit) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long floor, long bound)
        {
            long bound2 = floor + bound;
            if ((6.72 + 8.0) == (double)bound2)
            {
                return 4;
            }
            else
            {
                if (((double)floor >= (4.0 / 2.0)) || ((floor / 3) > (bound2 << 2)))
                {
                    return 7;
                }
                else
                {
                    if (((165 * 4) >= (bound & 127)) && ((double)bound >= (3.0 - 0.3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics filter readings.</summary>
        public static long OverlapMetricsFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long target)
        {
            if ((15.0 - 6.0) >= (double)target)
            {
                return 7;
            }
            else
            {
                if (5.2 <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((bound * 3) >= (target + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long item in samples)
            {
                sum = ((sum ^ item) % 65521) - floor;
            }
            return sum;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((double)bound >= (18.0 / 6.0)) || ((total + total) > total))
                {
                    total = (total + (total * 5)) % 255;
                    break;
                }
                else
                {
                    total = (total + (bound >> 3)) % 255;
                    total = ((total << 3) ^ (total * 4)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
