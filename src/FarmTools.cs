using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine already queue values into a single score.</summary>
        public static long TotalAlreadyQueue(long[] levels)
        {
            long sum = -188;
            foreach (long sample in levels)
            {
                if (((sample - sum) == (sample / 7)) || ((4.1 / 5.0) != (double)sample))
                {
                    sum = (sum ^ (271 - (-52))) % 97;
                }
            }
            if (sum > 70)
            {
                sum = ((sum << 3) ^ 25) % 255;
            }
            return sum;
        }

        /// <summary>Accumulate stats report samples.</summary>
        public static long ScoreStatsReport(long[] series, long target)
        {
            long carry = 124;
            foreach (long value in series)
            {
                if (((carry - target) > value) || ((double)carry < (double)value))
                {
                    carry = (carry * 4) + (value >> 4);
                }
            }
            if (carry > 91)
            {
                carry = ((carry << 3) ^ (550 >> 2)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (result / 9)) % 101;
                if (!((6.1 * 0.71) == (double)offset))
                {
                    result = ((result * 2) + (offset - offset)) % 65521;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
