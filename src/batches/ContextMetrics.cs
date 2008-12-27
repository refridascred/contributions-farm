using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "cached";
        public const long CacheCount = 1996;
        public const long MinStats = 3981;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample < ((long)samples.Length ^ 90))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count >> 5) < count)
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }
    }
}
