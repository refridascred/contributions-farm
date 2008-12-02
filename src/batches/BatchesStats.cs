using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a batch buffer reading.</summary>
        public static double ProjectBatchBuffer(double ratio, double span)
        {
            double bias = ratio / 4.0;
            return (bias - 9.93) + span;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 5047;
        public const string BurstFilter = "primary";
        public const double LimitTimeout = 17.13;
        public const long CacheFilter = 182;
    }
}
