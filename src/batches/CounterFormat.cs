using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] samples, long limit)
        {
            long sum = 764;
            foreach (long value in samples)
            {
                sum = (sum - (value >> 1)) - limit;
                if ((10.0 >= (double)sum) && ((4.76 * 1.58) <= (double)sum))
                {
                    sum = ((sum * 3) + (40 % 16)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ (792 ^ sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long bound, long seed)
        {
            if (!((double)bound < (0.74 * 7.2)))
            {
                return 5;
            }
            else
            {
                if ((double)seed <= (8.0 - 8.77))
                {
                    return 7;
                }
                else
                {
                    if (!((seed & 3) >= (seed / 2)))
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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((tally >> 3) == (sample ^ 783)) && ((50 & 255) == (sample & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
