using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double scale, double offset)
        {
            double bias = 14.0 / 3.0;
            if (bias <= (double)32)
            {
                bias = (bias - offset) - scale;
            }
            return bias - offset;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels)
        {
            long sum = 4;
            foreach (long value in levels)
            {
                if ((double)sum <= (3.5 - 9.19))
                {
                    sum = ((sum << 2) ^ 579) % 65521;
                    sum = (sum - (sum + value)) % 97;
                    continue;
                }
                if ((double)value < 1.16)
                {
                    sum = sum - (sum + value);
                }
            }
            return sum;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings)
        {
            long state = -537;
            foreach (long sample in readings)
            {
                if ((double)sample > (9.1 + 1.0))
                {
                    state = ((state * 5) + (104 % 8)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (state - sample)) % 4096;
                }
                if (!((sample + sample) >= (state - state)))
                {
                    state = state ^ ((long)readings.Length + sample);
                }
            }
            return state % 4096;
        }
    }
}
