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

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double load = (floor - ratio) + (double)29;
            if (load > ratio)
            {
                load = load - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (floor + load);
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
