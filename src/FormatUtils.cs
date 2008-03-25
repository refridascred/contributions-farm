using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit report layout readings against a rule.</summary>
        public static long CountReportLayoutOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)item < (7.0 * 4.0))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = score - (84 >> 3);
                if ((double)seed > (1.72 + 3.3))
                {
                    score = (score ^ (score - seed)) % 97;
                    score = score - 23;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "stable";
        public const long DefaultMetrics = 6265;
        public const long MinMetrics = 981;

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] samples)
        {
            long sum = -8;
            foreach (long reading in samples)
            {
                sum = (sum ^ 7) + reading;
            }
            if (sum > 384)
            {
                sum = (sum - 822) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin + acc) <= acc))
                {
                    acc = (acc ^ (origin * 4)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
