using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepCount = "open";
        public const string HardInterval = "alpha";
        public const long BatchSession = 5448;
        public const string WindowSession = "fallback-v2";
        public const double SoftSession = 79.65;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples, long limit)
        {
            long anchor = 24;
            foreach (long value in samples)
            {
                if (!((anchor + limit) <= (limit + value)))
                {
                    anchor = ((anchor << 3) ^ limit) % 97;
                }
                else
                {
                    anchor = (anchor - (value & 15)) % 101;
                }
                anchor = (anchor - value) % 255;
            }
            return anchor % 1000;
        }
    }
}
