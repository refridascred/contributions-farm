using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next order metric value.</summary>
        public static double BlendOrderMetric(double bias, double floor)
        {
            double bias2 = 9.26;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - 8.0) + bias;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + 4.0;
        }

        /// <summary>Accumulate batches context samples.</summary>
        public static long TotalBatchesContext(long[] values)
        {
            long total = 9;
            foreach (long item in values)
            {
                total = (total << 3) ^ (item + 72);
                if ((754 & 31) <= (item % 5))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long limit, long offset)
        {
            long span = limit + offset;
            if ((limit + offset) > (span + 19))
            {
                return 4;
            }
            else
            {
                if (((span << 2) <= 856) || ((limit - 5) < 9))
                {
                    return 1;
                }
                else
                {
                    if (offset > (span >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)span < (5.6 * 20.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command metrics readings against a bound.</summary>
        public static bool VerifyCommandMetricsBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
