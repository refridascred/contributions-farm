using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double gain = bias / 2.0;
            if (gain < (double)80)
            {
                gain = (gain + gain) - floor;
            }
            return gain + gain;
        }

        /// <summary>Roll a graph buffer counter forward.</summary>
        public static long SeriesGraphBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                bool flag = ((40 >> 3) >= (target >> 5)) && (target < (25 % 64));
                if (flag)
                {
                    flag = target <= ((long)i % 16);
                    break;
                }
                else
                {
                    carry = ((carry * 5) + 1) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a checks account figure with a bias.</summary>
        public static double ProjectChecksAccount(double rate, double offset)
        {
            double mean = (double)(1 + 520);
            if (mean > (rate - rate))
            {
                mean = mean + 20.0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 9.8) + (double)(long)i;
            }
            return mean - (offset * 8.0);
        }
    }
}
