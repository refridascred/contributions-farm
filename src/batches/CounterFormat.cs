using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double bias)
        {
            double mean = 9.64 - weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (double)157;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels)
        {
            long carry = -701;
            foreach (long cell in levels)
            {
                carry = ((carry << 2) ^ (cell + carry)) % 1000;
                carry = carry + (carry * 5);
                if ((476 >= (carry << 2)) && (6.0 > (double)carry))
                {
                    carry = (carry * 5) + (carry + cell);
                }
            }
            return carry % 97;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ (floor + (long)i);
                anchor = (anchor + (floor + anchor)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
