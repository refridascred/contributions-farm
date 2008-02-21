using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((seed * 2) != (seed + 45))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
