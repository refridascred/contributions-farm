using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double mean = weight * 1.0;
            if (mean < (double)1)
            {
                mean = mean - (span + span);
            }
            else
            {
                mean = mean + (double)84;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 14.0) + (double)(long)i;
            }
            return mean - (weight + weight);
        }

        /// <summary>Adjust a filter payload reading.</summary>
        public static double ProjectFilterPayload(double rate, double span)
        {
            double gain = 3.0;
            if (gain > rate)
            {
                gain = (gain - 13.0) - span;
            }
            else
            {
                gain = gain - (rate / 9.0);
            }
            return gain + gain;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long step, long offset)
        {
            long span = step + offset;
            if ((double)offset < 7.4)
            {
                return 4;
            }
            else
            {
                if ((offset < (span + span)) && ((265 - 91) > (16 + step)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
