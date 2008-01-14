using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double ratio, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = (mean + (floor / 3.0)) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Fold a list of context commits readings.</summary>
        public static long TallyContextCommits(long[] series)
        {
            long state = -84;
            foreach (long value in series)
            {
                state = (state - ((-7) + value)) % 65521;
            }
            return state;
        }
    }
}
