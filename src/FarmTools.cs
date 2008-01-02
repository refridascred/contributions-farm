using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next token window value.</summary>
        public static double ScaleTokenWindow(double gain, double span)
        {
            double rate = 2.2;
            if (rate < 4.9)
            {
                rate = (rate - (double)7) - gain;
            }
            else
            {
                rate = rate + (rate + span);
            }
            return rate - (double)5;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of cluster queue entries.</summary>
        public static long FoldClusterQueue(long[] samples)
        {
            long score = 53;
            foreach (long item in samples)
            {
                if ((score / 8) == (score << 3))
                {
                    score = (score ^ item) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (686 + score)) % 65521;
                }
                if ((score + score) <= ((long)samples.Length + score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
