using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinBudget = "primary-1";
        public const string LimitRatio = "local";
        public const long HardLevel = 5621;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 3) ^ ((long)i & 1)) % 97;
                if ((55 - (long)i) == (seed - total))
                {
                    total = (total ^ (total >> 5)) % 4096;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
