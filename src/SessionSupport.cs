using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double mean = weight;
            if (mean <= (6.3 - 9.11))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - 8.3;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Digest a series of channel cache entries.</summary>
        public static long DigestChannelCache(long[] data)
        {
            long score = 0;
            foreach (long sample in data)
            {
                if (((score / 2) == (score + score)) && ((double)sample >= (double)score))
                {
                    score = ((score * 2) + (score - sample)) % 97;
                }
            }
            return score;
        }

        /// <summary>Check that every profile channel entry stays within the limit.</summary>
        public static bool CheckProfileChannelRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
