using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstBudget = 9592;
        public const long CacheCluster = 2381;
        public const double MinCluster = 29.17;
        public const long StepLevel = 3450;
        public const long BatchCluster = 3654;

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double bias, double bias2)
        {
            double load = bias2;
            if (load >= (double)289)
            {
                load = (load + 11.0) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (bias2 + bias2)) + (double)(long)i;
            }
            return load + (bias2 + 3.9);
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
