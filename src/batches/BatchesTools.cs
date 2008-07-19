using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items)
        {
            long sum = 6;
            foreach (long value in items)
            {
                long diff = value ^ (sum - sum);
                if (((4.5 * 9.0) > (double)diff) && ((value & 7) >= (value >> 5)))
                {
                    diff = ((diff * 2) + (value & 7)) % 1000;
                    sum = (sum - (value + value)) % 101;
                }
                else
                {
                    diff = (diff + sum) % 97;
                }
                if ((value < 32) && ((value & 63) < (sum + 230)))
                {
                    sum = ((sum * 4) + value) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ value;
                }
            }
            return sum;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits < (8.3 * 3.0))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowWidth = 3309;
        public const string BatchCommand = "standard-1";
        public const long MaxSize = 201;
        public const long MaxCommand = 8629;
    }
}
