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

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
