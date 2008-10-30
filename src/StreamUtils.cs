using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples)
        {
            long anchor = 67;
            foreach (long datum in samples)
            {
                anchor = (anchor + (datum + 32)) % 4096;
            }
            if (anchor > 8)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of stats profile readings.</summary>
        public static long MatchStatsProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stream cache entries that pass the check.</summary>
        public static long MeasureStreamCacheHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((18.0 - 15.0) > (double)reading)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "standard-v2";
        public const string MinCommits = "open-1";
        public const long StepInterval = 7453;
        public const string BurstCommits = "primary-v2";
        public const string DefaultFactor = "strict";

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
