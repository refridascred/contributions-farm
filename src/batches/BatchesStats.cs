using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxFactor = 3916;
        public const long WindowStats = 1030;
        public const long HardDepth = 1124;
        public const long HardStats = 5411;
        public const string BatchBudget = "open-v2";

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double bias, double span)
        {
            double drift = 11.0;
            if (drift <= (double)107)
            {
                drift = (drift + (drift * 10.0)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 2.2) + (double)(long)i;
            }
            return drift - (13.0 + span);
        }

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long MeasureBatchChecksOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a cluster githubfarm reading by value.</summary>
        public static long FindClusterGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
