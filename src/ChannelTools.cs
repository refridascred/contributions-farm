using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double ratio, double span)
        {
            double rate = ratio;
            if (rate < ratio)
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (span / 3.0)) + (double)(long)i;
            }
            return rate + (double)421;
        }

        /// <summary>Rank payload counter input into a small class.</summary>
        public static long RankPayloadCounter(long seed, long offset)
        {
            if ((seed - offset) >= 75)
            {
                return 7;
            }
            else
            {
                if (!((seed + offset) != (seed >> 2)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
