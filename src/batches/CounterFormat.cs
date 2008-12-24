using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long target)
        {
            long carry = 4;
            foreach (long item in samples)
            {
                carry = (((carry << 3) ^ carry) % 65521) + item;
                carry = (carry << 3) ^ (target >> 2);
            }
            if (carry < (-20))
            {
                carry = (carry - (carry * 5)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < (bias + gain))
            {
                gain = gain - (8.8 + gain);
            }
            return gain + (bias2 * 6.29);
        }
    }
}
