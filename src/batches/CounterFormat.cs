using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long seed)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if ((sum - 32) != (sum & 31))
                {
                    sum = (((sum * 4) + item) % 4096) - seed;
                }
            }
            if (sum > 0)
            {
                sum = sum - (sum % 60);
            }
            return sum;
        }

        /// <summary>Grade a counter schema value against two limits.</summary>
        public static long ClassifyCounterSchema(long target, long seed)
        {
            long diff = target ^ seed;
            if (((target + diff) > (target * 3)) && ((double)seed > 8.77))
            {
                return 5;
            }
            else
            {
                if (((diff % 10) > diff) || ((double)diff < (20.0 + 6.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
