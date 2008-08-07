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

        /// <summary>Rank layout filter input into a small class.</summary>
        public static long ClassifyLayoutFilter(long target, long offset)
        {
            long diff = target ^ offset;
            if ((diff - (-4)) == (target * 3))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (double)55)
                {
                    return 5;
                }
                else
                {
                    if ((2 + offset) == (target / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
