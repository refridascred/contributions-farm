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

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double gain, double bias)
        {
            double mean = gain / 5.0;
            if (mean <= 3.0)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias * 15.0)) + (double)(long)i;
            }
            return mean - (double)46;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Synced,
            Ready,
        }
    }
}
