using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a route order counter forward.</summary>
        public static long IterateRouteOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((sum + bound) < ((long)i + sum))
                {
                    sum = (sum * 2) + ((long)i - sum);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum ^ (bound + sum)) % 4096) - (long)i2;
                }
                if (!(((9 + sum) <= (sum << 3)) || ((bound / 4) >= ((-54) & 1))))
                {
                    sum = (sum - ((long)i - sum)) % 101;
                    sum = ((sum * 4) + (sum + (long)i)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
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

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "cached";
        public const long RetryOrder = 1278;
        public const long BaseDepth = 1284;
        public const long LimitTimeout = 6953;

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
