using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheTimeout = 465;
        public const long CacheSupport = 912;
        public const double StepScore = 26.89;
        public const double BurstSpan = 70.49;
        public const long CacheRatio = 8375;

        /// <summary>Adjust a tools report reading.</summary>
        public static double BlendToolsReport(double weight, double bias)
        {
            double scale = (7.37 + weight) / 2.0;
            if (scale >= (scale - weight))
            {
                scale = scale + (bias * 1.9);
            }
            else
            {
                scale = scale + weight;
            }
            return scale + (double)4;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series, long offset)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                mark = (((mark << 2) ^ (mark & 255)) ^ entry) + offset;
            }
            return mark % 97;
        }
    }
}
