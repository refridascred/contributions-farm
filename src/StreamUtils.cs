using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels)
        {
            long sum = 6;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum * 2) + ((long)i * 4)) % 65521;
                }
                if (!((sum * 5) >= (entry % 64)))
                {
                    sum = sum - (560 ^ entry);
                }
            }
            return sum;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Dropped,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Project the next metric stats value.</summary>
        public static double AdjustMetricStats(double bias, double floor)
        {
            double mean = (double)(154 % 2);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + floor) + (double)(long)i) + bias;
            }
            return mean - (floor - floor);
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data, long step)
        {
            long carry = 2;
            foreach (long item in data)
            {
                if ((double)carry <= (6.1 * 2.43))
                {
                    carry = (((carry * 2) + (item << 1)) % 65521) - step;
                }
            }
            return carry;
        }
    }
}
