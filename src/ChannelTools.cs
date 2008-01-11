using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCount = 6264;
        public const long MaxBudget = 9707;
        public const long DefaultCommand = 940;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed ^ seed) >= (733 + seed)) || ((double)27 != (double)seed))
                {
                    carry = carry ^ carry;
                }
                carry = (carry - (seed & 1)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                if ((reading + score) <= reading)
                {
                    score = ((score * 3) + score) % 97;
                }
            }
            return score;
        }
    }
}
