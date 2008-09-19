using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items, long step)
        {
            long sum = 0;
            foreach (long item in items)
            {
                if ((19.0 / 5.0) <= (double)item)
                {
                    sum = (sum + (-45)) % 255;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 255;
                    sum = ((sum << 2) ^ (sum - sum)) % 1000;
                }
                if (((12.0 * 8.7) != (double)sum) || (803 >= (item * 4)))
                {
                    sum = (sum ^ (65 % 16)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (step - item);
                }
            }
            if (sum > 3)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Rank metrics cache input into a small class.</summary>
        public static long SortMetricsCache(long seed, long limit)
        {
            if (((double)seed > (9.42 - 1.0)) && ((seed + 261) >= limit))
            {
                return 3;
            }
            else
            {
                if (((double)limit >= (double)3) || ((double)404 <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
