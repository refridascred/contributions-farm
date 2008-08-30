using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double weight = bias;
            if (weight < (9.0 / 2.0))
            {
                weight = weight - gain;
            }
            return weight + gain;
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
