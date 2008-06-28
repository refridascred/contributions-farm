using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public bool Size { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                if ((anchor + anchor) > anchor)
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor % 100);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long acc = 372;
            foreach (long datum in samples)
            {
                acc = ((acc << 3) ^ datum) % 255;
                if (acc < (datum * 5))
                {
                    acc = acc - (acc + datum);
                }
                else
                {
                    acc = ((acc * 5) + 950) % 1000;
                }
            }
            if (acc < 785)
            {
                acc = (acc * 2) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double floor)
        {
            double rate = scale + floor;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (7.41 - rate)) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
