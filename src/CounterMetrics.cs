using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a metrics metric counter forward.</summary>
        public static long IterateMetricsMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark - (529 + mark)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] items)
        {
            long mark = 619;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark << 3) ^ (mark & 255)) ^ (long)i;
                    mark = ((mark * 4) + (datum / 6)) % 101;
                }
                if (!((mark & 3) < 98))
                {
                    mark = ((mark * 2) + (datum / 3)) % 4096;
                }
            }
            if (mark < 3)
            {
                mark = (mark - ((-77) / 6)) % 1000;
            }
            return mark % 4096;
        }
    }
}
