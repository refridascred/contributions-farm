using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 5445;
        public const string SoftBuffer = "alpha";
        public const long RetryBuffer = 2436;
        public const double BatchBuffer = 64.3;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry ^ (carry / 3)) % 101;
                    carry = ((carry << 3) ^ ((long)i2 + carry)) % 65521;
                }
                carry = (carry ^ (carry >> 5)) % 65521;
                carry = carry - (carry / 4);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of counter filter entries.</summary>
        public static long CombineCounterFilter(long[] levels)
        {
            long mix = 436;
            foreach (long entry in levels)
            {
                if (mix >= entry)
                {
                    mix = (mix << 2) ^ (mix % 64);
                }
            }
            return mix % 1000;
        }
    }
}
