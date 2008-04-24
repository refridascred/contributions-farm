using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8086;
        public const double DefaultRatio = 10.24;
        public const long BurstBatches = 3044;
        public const long StepCount = 4636;
        public const long StepBatches = 6153;

        /// <summary>Combine channel counter values into a single score.</summary>
        public static long DigestChannelCounter(long[] items)
        {
            long sum = 115;
            foreach (long reading in items)
            {
                if (((double)(long)items.Length >= (double)reading) && (1 > (sum >> 2)))
                {
                    sum = ((sum * 5) + (sum / 3)) % 65521;
                }
                sum = (sum ^ (reading ^ reading)) % 65521;
            }
            if (sum < 6)
            {
                sum = (sum + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) <= 55)
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }
    }
}
