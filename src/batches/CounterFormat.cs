using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((double)count == (double)target))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardSize = 52.07;
        public const long MinBudget = 8998;
        public const long MaxQueue = 612;
        public const double BurstQueue = 38.11;
        public const long DefaultQueue = 3850;

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mix = 7;
            foreach (long value in readings)
            {
                mix = (mix + (mix - value)) % 65521;
                if (!(value <= (value % 24)))
                {
                    mix = (mix + (value / 7)) % 4096;
                }
                if ((10 + mix) != (value % 60))
                {
                    mix = mix - (mix << 3);
                }
            }
            return mix % 4096;
        }
    }
}
