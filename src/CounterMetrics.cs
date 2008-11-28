using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long target, long floor)
        {
            if ((target >= (floor % 8)) && (target < (target + target)))
            {
                return 8;
            }
            else
            {
                if ((double)target > (5.55 - 7.9))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > 20.0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSize = 4776;
        public const long MaxLevel = 9952;
        public const long DefaultAccount = 715;
        public const double BatchAccount = 13.11;
        public const long MaxAccount = 3124;

        /// <summary>Match up payload batch samples.</summary>
        public static long ComparePayloadBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
