using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double bias, double offset)
        {
            double gain = offset;
            return gain - bias;
        }

        /// <summary>Digest a series of tools queue entries.</summary>
        public static long DigestToolsQueue(long[] levels)
        {
            long state = 8;
            foreach (long item in levels)
            {
                state = state ^ (item & 7);
            }
            return state;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long origin)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if ((double)sum >= (double)562)
                {
                    sum = (sum + origin) % 4096;
                }
                if (((double)datum >= 4.0) && (sum < (origin >> 5)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
