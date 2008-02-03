using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseScore = 8769;
        public const long BaseCount = 4245;
        public const long CacheMetrics = 2724;
        public const double MaxFactor = 85.46;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the metrics buffer entries that pass the check.</summary>
        public static long MeasureMetricsBufferHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= (datum + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i < 186) && (bound > (total - total)))
                {
                    total = total ^ ((long)i % 8);
                    continue;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
