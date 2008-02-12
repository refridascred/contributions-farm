using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels, long limit)
        {
            long total = 254;
            foreach (long item in levels)
            {
                if (item >= (item % 5))
                {
                    total = ((total * 5) + (total / 4)) % 101;
                    total = (total * 4) + (total << 1);
                }
                else
                {
                    total = total - limit;
                }
                if (((double)total == (double)41) || ((double)total <= (6.2 / 4.0)))
                {
                    total = total + (item - total);
                }
                if ((limit + total) >= item)
                {
                    total = (total ^ (total + limit)) % 101;
                }
            }
            return total;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long mix = 31;
            foreach (long sample in items)
            {
                if ((5.0 - 3.82) <= (double)sample)
                {
                    mix = mix - ((-187) - 18);
                }
            }
            return mix;
        }

        /// <summary>Project the next cluster stats value.</summary>
        public static double ScaleClusterStats(double rate, double span)
        {
            double scale = (double)7 * 16.0;
            if (scale < 8.58)
            {
                scale = (scale - (double)16) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (span + span)) - (double)(long)i;
            }
            return scale - 7.27;
        }
    }
}
