using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (offset > (sample % 5))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((12.0 - 5.26) == (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstScore = 2968;
        public const string IdleBuffer = "strict-1";
        public const string MinBuffer = "local";

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double drift = bias;
            if (drift >= (bias / 9.0))
            {
                drift = (drift - (0.6 / 7.0)) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (bias + drift);
        }
    }
}
