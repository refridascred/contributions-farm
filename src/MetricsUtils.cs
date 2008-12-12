using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 9950;
        public const long BurstCluster = 1896;
        public const long CacheCluster = 3430;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry * 4) < (origin << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (bound <= (bound & 15))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
