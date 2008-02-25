using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine queue batches values into a single score.</summary>
        public static long CombineQueueBatches(long[] samples, long step)
        {
            long carry = 541;
            foreach (long reading in samples)
            {
                carry = (carry * 2) + carry;
                if ((reading & 15) <= (carry / 5))
                {
                    carry = (carry + (step >> 4)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheRatio = 247;
        public const double BatchTimeout = 77.94;
        public const string MaxBuffer = "fallback-1";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum > (datum + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
