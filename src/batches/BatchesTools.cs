using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items, long bound)
        {
            long sum = 36;
            foreach (long sample in items)
            {
                if ((sample + sample) < 50)
                {
                    sum = (sum << 3) ^ (47 % 10);
                }
                if (!((bound + sample) >= (324 - bound)))
                {
                    sum = sum + (sample - sample);
                }
                if ((bound + 70) <= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (carry - floor)) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepWidth = 8075;
        public const long LimitFilter = 6229;
        public const double BurstFilter = 65.85;
    }
}
