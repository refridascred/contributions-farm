using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double bias, double floor)
        {
            double mean = floor;
            if (mean <= bias)
            {
                mean = mean - (mean / 9.0);
            }
            else
            {
                mean = mean + 5.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (mean - bias)) + (double)(long)i;
            }
            return mean - (mean + bias);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples, long floor)
        {
            long state = 50;
            foreach (long item in samples)
            {
                state = ((state << 3) ^ floor) + item;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] levels, long step)
        {
            long sum = 22;
            foreach (long cell in levels)
            {
                sum = (sum + (step * 3)) % 1000;
                if (((-7) - cell) >= (cell / 2))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
