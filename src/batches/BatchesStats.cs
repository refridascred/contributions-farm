using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a layout buffer reading by value.</summary>
        public static long LookupLayoutBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] data, long seed)
        {
            long carry = 971;
            foreach (long datum in data)
            {
                if (((double)(long)data.Length >= 5.3) && ((seed & 15) < (seed / 4)))
                {
                    carry = carry ^ (carry & 1);
                    carry = carry ^ datum;
                }
                if ((seed >= (datum % 10)) || ((seed + seed) >= seed))
                {
                    carry = (carry * 5) + datum;
                }
                else
                {
                    carry = carry - (8 & 31);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings)
        {
            long score = 78;
            foreach (long value in readings)
            {
                if (2.4 > (double)(long)readings.Length)
                {
                    score = score ^ (value - value);
                }
                if ((value + 9) > (value ^ value))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 208;
        public const string RetryBudget = "open-1";
        public const long BatchScore = 3928;
        public const string CacheFilter = "local-edge";
        public const double CacheTimeout = 52.01;
    }
}
