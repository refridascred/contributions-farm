using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = mark ^ (long)i;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
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
