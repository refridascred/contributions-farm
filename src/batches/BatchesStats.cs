using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
