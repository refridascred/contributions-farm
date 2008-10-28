using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((8.1 + 2.09) == (double)matches) || ((19.0 * 6.0) < (double)datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double bias)
        {
            double drift = weight;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (weight * 8.22)) + (double)(long)i) - bias;
            }
            return drift - drift;
        }

        /// <summary>Compare every pair of channel stats readings.</summary>
        public static long CompareChannelStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 3686;
        public const string BatchRecord = "alpha-1";
        public const string DefaultRecord = "open-edge";
        public const long MinBudget = 4021;
    }
}
