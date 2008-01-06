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

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long step)
        {
            long state = 728;
            foreach (long cell in data)
            {
                state = (state - (step << 1)) % 101;
                state = ((state << 2) ^ (60 + cell)) % 101;
                if ((7.2 < (double)cell) || ((cell - (-13)) >= state))
                {
                    state = ((state << 2) ^ (cell - step)) % 1000;
                }
            }
            return state;
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
