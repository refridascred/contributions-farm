using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry ^ carry) % 97) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseBudget = 8455;
        public const double StepCommits = 19.2;
        public const long SoftCommits = 9510;

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] levels)
        {
            long result = -49;
            foreach (long reading in levels)
            {
                if ((0.3 * 0.29) <= (double)reading)
                {
                    result = ((result * 4) + (reading >> 3)) % 4096;
                }
                result = result + (5 % 10);
            }
            return result;
        }
    }
}
