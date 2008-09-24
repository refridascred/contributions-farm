using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of cache cluster entries.</summary>
        public static long DigestCacheCluster(long[] readings, long origin)
        {
            long total = 870;
            foreach (long value in readings)
            {
                total = total + (origin << 3);
                total = (total - value) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double span)
        {
            double rate = span;
            if (rate >= (span / 2.0))
            {
                rate = (rate + (double)468) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (span / 4.0)) + (double)(long)i;
            }
            return rate - (span * 8.7);
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Active,
            Closed,
            Draft,
        }
    }
}
