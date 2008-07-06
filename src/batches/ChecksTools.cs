using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double rate, double bias)
        {
            double bias2 = bias / 9.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - rate) - (double)(long)i;
            }
            return bias2 + (double)33;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] values, long bound)
        {
            long score = 9;
            foreach (long sample in values)
            {
                score = (score + (score * 4)) - sample;
                score = (score + (bound & 1)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
