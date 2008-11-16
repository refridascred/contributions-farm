using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long mark = 20;
            foreach (long datum in levels)
            {
                if ((double)mark == (double)datum)
                {
                    mark = (mark << 3) ^ datum;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3015;
        public const double DefaultLevel = 39.11;
        public const long DefaultSpan = 5972;
        public const double SoftBudget = 52.08;
        public const long BurstEditor = 1275;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double weight, double span)
        {
            double mean = (span * 4.0) - (4.3 / 6.0);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + 7.8) + (double)(long)i) - weight;
            }
            return mean + span;
        }
    }
}
