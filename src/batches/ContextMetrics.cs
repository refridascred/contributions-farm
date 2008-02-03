using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 6509;
        public const double CacheSize = 4.2;
        public const long HardBudget = 6895;
        public const string LimitSupport = "latest-v2";
        public const long StepFactor = 5150;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double offset)
        {
            double rate = 9.8 - (gain * 20.0);
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 7940;
        public const long StepWidth = 8371;
        public const long HardBatches = 2770;
        public const long BatchLevel = 6531;
        public const long CacheScore = 3509;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxDepth = 5459;
        public const string MinSpan = "stable-edge";
        public const long BaseCache = 6602;
    }
}
