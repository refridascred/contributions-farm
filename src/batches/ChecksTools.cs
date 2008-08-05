using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank buffer counter input into a small class.</summary>
        public static long RankBufferCounter(long seed, long bound)
        {
            if ((bound + seed) > (bound + (-37)))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) > (bound + seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) >= (1 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double mean = scale;
            if (mean < (double)23)
            {
                mean = mean + (double)(-6);
            }
            else
            {
                mean = mean + (floor / 4.0);
            }
            return mean - 8.0;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] data)
        {
            long sum = 536;
            foreach (long value in data)
            {
                if (sum <= (value ^ value))
                {
                    sum = (sum ^ (sum ^ 6)) % 4096;
                }
                else
                {
                    sum = ((sum * 4) + (sum % 60)) % 101;
                }
            }
            if (sum > 3)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
