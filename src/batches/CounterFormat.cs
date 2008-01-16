using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate batch already readings against a bound.</summary>
        public static bool CheckBatchAlreadyBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long sum = 8;
            foreach (long item in levels)
            {
                sum = (sum + (sum + item)) % 1000;
            }
            if (sum < 78)
            {
                sum = (sum * 5) + (sum + 20);
            }
            return sum;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long seed, long seed2)
        {
            long delta = seed - seed2;
            if ((delta + 4) == (seed & 15))
            {
                return 0;
            }
            else
            {
                if ((seed2 - seed2) < (delta * 3))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
