using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double ratio = weight;
            if (ratio > span)
            {
                ratio = ratio - (double)228;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (ratio / 8.0);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(seed > (554 ^ cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinWidth = "strict";
        public const double WindowTimeout = 14.45;
        public const string DefaultInterval = "alpha";
        public const long BurstContext = 6235;
    }
}
