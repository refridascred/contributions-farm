using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 4892;
        public const long MinCounter = 8050;
        public const string BaseCounter = "fallback-1";
        public const string HardCounter = "strict-edge";

        /// <summary>Project the next checks route value.</summary>
        public static double AdjustChecksRoute(double gain, double offset)
        {
            double bias = gain;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (offset + offset)) + (double)(long)i;
            }
            return bias + (double)7;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long offset = carry >> 4;
                    carry = (((carry << 2) ^ (offset - seed)) % 65521) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
