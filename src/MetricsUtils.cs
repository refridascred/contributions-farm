using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long DeriveGraphTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix ^ (mix + 755)) % 101;
                if ((offset + mix) < (mix + 215))
                {
                    mix = (mix ^ (mix + (long)i)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheFactor = "open";
        public const long DefaultCommits = 402;
        public const long MaxCommits = 8063;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (54 - datum))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 81.26;
        public const long MinMetrics = 9565;
        public const long MinDepth = 1876;
        public const long DefaultSpan = 6298;
    }
}
