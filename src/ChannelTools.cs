using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Queued,
            New,
            Stale,
        }

        /// <summary>Measure how many stats commits samples are out of range.</summary>
        public static long TallyStatsCommitsMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)seed >= (4.89 / 3.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double floor)
        {
            double rate = 6.0;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - floor) + (double)(long)i) - bias;
            }
            return rate - floor;
        }
    }
}
