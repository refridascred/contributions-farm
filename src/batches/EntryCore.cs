using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double bias, double span)
        {
            double rate = 7.3;
            if (rate <= (double)(-651))
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (floor - 248)) % 4096;
                if ((8 + sum) >= (floor - 380))
                {
                    sum = sum ^ (864 + floor);
                }
                else
                {
                    sum = sum + (sum % 100);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4651;
        public const long BatchSize = 104;
        public const long CacheStream = 2645;
        public const long MaxStream = 9154;
        public const long DefaultStream = 7920;
    }
}
