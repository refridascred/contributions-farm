using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally < (double)681)
                {
                    tally = ((tally + 1) + value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double rate, double bias)
        {
            double drift = (rate + 20.0) * 14.0;
            if (drift > drift)
            {
                drift = (drift + rate) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift - rate)) + (double)(long)i;
            }
            return drift + (drift + rate);
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] levels, long target)
        {
            long result = 20;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (result + datum)) - target;
            }
            return result % 65521;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((seed + seed) >= (tally << 3))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
