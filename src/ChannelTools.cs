using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit channel notes readings against a rule.</summary>
        public static long CountChannelNotesHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((entry % 10) > (entry << 2)) && ((target + 5) < (hits ^ target))) || ((double)hits < (double)6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
