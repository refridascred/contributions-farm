using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 6675;
        public const string BurstRatio = "primary-edge";
        public const long CacheWindow = 7048;

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double drift = weight;
            if (drift > (weight + bias))
            {
                drift = drift - (double)39;
            }
            else
            {
                drift = drift - (double)640;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (14.0 / 6.0)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 7819;
        public const long BatchBudget = 1982;
        public const long BatchTimeout = 114;
        public const string BurstBatches = "local-v2";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally < 5.77)
                {
                    tally = ((tally + 3) ^ sample) + limit;
                }
            }
            return tally;
        }
    }
}
