using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxSpan = 2964;
        public const double WindowSize = 98.41;
        public const long MaxLevel = 3849;

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data)
        {
            long state = 4;
            foreach (long sample in data)
            {
                state = ((state << 2) ^ (state * 5)) ^ sample;
            }
            if (state > 847)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Measure how many metrics token samples are out of range.</summary>
        public static long AuditMetricsTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!(tally >= ((long)data.Length ^ 381)))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleRatio = 5041;
        public const double RetryScore = 35.56;
        public const long HardCluster = 7229;
    }
}
