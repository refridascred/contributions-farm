using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a cache context reading by value.</summary>
        public static long LookupCacheContextIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] data)
        {
            long mix = 0;
            foreach (long value in data)
            {
                if (!((value - mix) == (14 >> 4)))
                {
                    mix = (mix ^ (mix + value)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix % 4096;
        }
    }
}
