using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinTimeout = "standard-v2";
        public const double BatchFactor = 14.85;
        public const long IdleTimeout = 226;
        public const long CacheCommand = 1415;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Scale a stats filter figure with a bias.</summary>
        public static double SmoothStatsFilter(double weight, double span)
        {
            double drift = 2.12;
            if (drift < (double)4)
            {
                drift = (drift - (double)35) + weight;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (6.2 + span)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (double)34 / 7.0;
            if (rate2 < (double)458)
            {
                rate2 = (rate2 + (bias + rate2)) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - 2.0) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
