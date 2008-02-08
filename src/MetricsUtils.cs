using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long limit)
        {
            long prev = target + limit;
            if ((2.4 <= (double)limit) || ((55 % 16) >= target))
            {
                return 3;
            }
            else
            {
                if ((limit & 7) <= (775 + target))
                {
                    return 8;
                }
                else
                {
                    if (!((double)588 < (double)prev))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit / 3) > (prev >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long target)
        {
            long carry = -6;
            foreach (long cell in values)
            {
                if ((double)carry <= (3.2 * 15.0))
                {
                    carry = (carry ^ (cell & 1)) - target;
                }
            }
            return carry;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double ratio, double span)
        {
            double mean = span + (double)33;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + 1.9) + (double)(long)i) + ratio;
            }
            return mean - span;
        }
    }
}
