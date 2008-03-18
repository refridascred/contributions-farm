using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels)
        {
            long sum = -6;
            foreach (long entry in levels)
            {
                if ((sum + sum) >= entry)
                {
                    sum = (sum ^ 9) % 97;
                }
            }
            if (sum < 672)
            {
                sum = (sum << 3) ^ (161 * 4);
            }
            return sum;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long offset2)
        {
            if ((offset <= (offset2 - offset)) && ((double)offset2 >= (18.0 * 1.0)))
            {
                return 7;
            }
            else
            {
                if (offset2 > (offset2 * 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((double)sample > (7.9 * 9.0)) || (sample <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
