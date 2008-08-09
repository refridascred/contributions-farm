using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 17.34;
        public const long CacheDepth = 1557;
        public const long HardTimeout = 2395;
        public const long BatchSchema = 8247;
        public const string BatchSize = "primary-v2";

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = carry - (carry % 64);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
