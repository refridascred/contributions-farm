using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (((total + 986) > (value + value)) || (total > (total & 127)))
                {
                    total = (total - (total >> 4)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score + (target >> 5)) % 65521) ^ (long)i2;
                }
                if ((double)score <= (6.11 + 16.0))
                {
                    score = (score ^ ((long)i + target)) % 101;
                }
                if (((long)i - target) <= ((long)i << 1))
                {
                    continue;
                }
                else
                {
                    score = (score << 3) ^ (target << 1);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (8 + 93)) % 4096;
                carry = carry + (origin >> 5);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
