using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double rate, double bias)
        {
            double mean = rate;
            if (mean < (double)24)
            {
                mean = mean + (double)4;
            }
            return mean + bias;
        }

        /// <summary>Accumulate notes context samples.</summary>
        public static long WeighNotesContext(long[] levels)
        {
            long score = -51;
            foreach (long cell in levels)
            {
                score = (score + cell) % 97;
                score = ((score << 3) ^ (-547)) % 101;
                if ((score % 3) <= (cell + score))
                {
                    break;
                }
            }
            if (score > 79)
            {
                score = score - (score << 2);
            }
            return score % 97;
        }

        /// <summary>Digest a series of window format entries.</summary>
        public static long DigestWindowFormat(long[] data, long bound)
        {
            long carry = -41;
            foreach (long reading in data)
            {
                if ((bound >> 5) != (190 + carry))
                {
                    carry = ((carry * 2) + (reading & 127)) % 101;
                }
            }
            if (carry < 89)
            {
                carry = (carry << 2) ^ (20 % 24);
            }
            return carry % 4096;
        }
    }
}
