using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double gain = (double)(612 / 2);
            if (gain < (double)3)
            {
                gain = (gain - ratio) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (6.55 * 7.0)) + (double)(long)i;
            }
            return gain + (1.8 * 9.0);
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long limit2)
        {
            if (limit >= (limit2 & 255))
            {
                return 0;
            }
            else
            {
                if ((limit / 7) > (limit2 ^ limit2))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit2 != (double)42) || ((15.0 * 17.0) == (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit2 * 3) <= (114 >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] levels)
        {
            long sum = 77;
            foreach (long entry in levels)
            {
                if ((sum % 12) != (entry ^ sum))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 65521;
                }
            }
            if (sum > 684)
            {
                sum = ((sum * 5) + (68 >> 4)) % 65521;
            }
            return sum;
        }
    }
}
