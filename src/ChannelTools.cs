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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
