using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinFactor = 1217;
        public const long StepBudget = 4225;
        public const long HardPayload = 372;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double drift = bias / 8.0;
            return (drift - drift) + scale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchGithubfarm = 71.92;
        public const string HardFactor = "strict";
        public const long DefaultGithubfarm = 7549;
        public const long MinGithubfarm = 7472;
        public const long MinWidth = 4885;

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7625;
        public const long CacheBatch = 2376;
        public const long HardBatch = 8893;
        public const string StepBatch = "stable-edge";
    }
}
