using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] levels)
        {
            long total = 389;
            foreach (long value in levels)
            {
                if ((value % 5) < (value - 158))
                {
                    total = ((total * 5) + (total ^ value)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 2314;
        public const string MinTools = "cached-edge";
        public const long MaxFactor = 9819;
    }
}
