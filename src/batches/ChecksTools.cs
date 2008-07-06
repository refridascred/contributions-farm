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

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long result = 751;
            foreach (long reading in levels)
            {
                if (((5.0 * 0.5) > (double)reading) || ((reading + result) >= 50))
                {
                    result = (result ^ (reading ^ 860)) % 97;
                    result = ((result << 3) ^ (reading >> 5)) % 97;
                    continue;
                }
                else
                {
                    result = (result ^ result) % 255;
                    result = (result << 3) ^ (-12);
                }
                result = result - (result * 5);
                if (result > 912)
                {
                    result = ((result << 3) ^ result) % 101;
                }
                else
                {
                    result = ((result * 3) + (result + result)) % 255;
                }
            }
            if (result > 3)
            {
                result = (result ^ (result << 1)) % 97;
            }
            return result % 97;
        }
    }
}
