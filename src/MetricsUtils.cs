using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 4928;
        public const double RetryCache = 41.22;
        public const long HardScore = 7426;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (4.3 + 6.85))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Active,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series, long limit)
        {
            long mark = 702;
            foreach (long sample in series)
            {
                mark = mark ^ (sample >> 1);
                if (mark > (sample ^ limit))
                {
                    mark = (mark - (sample >> 1)) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ ((-6) >> 2)) % 4096;
                }
                if (limit <= (sample ^ sample))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
