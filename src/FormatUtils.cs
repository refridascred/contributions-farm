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

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "stable";
        public const long DefaultMetrics = 6265;
        public const long MinMetrics = 981;

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long acc = 348;
            foreach (long reading in series)
            {
                if ((reading <= (17 >> 2)) && ((1.9 - 3.0) > (double)acc))
                {
                    acc = (acc * 5) + (acc + reading);
                    acc = (acc << 2) ^ (reading - acc);
                    break;
                }
                if ((acc << 2) <= acc)
                {
                    acc = (acc - 64) % 97;
                }
                acc = ((acc << 2) ^ acc) % 97;
            }
            if (acc < 318)
            {
                acc = ((acc * 2) + (acc + acc)) % 4096;
            }
            return acc % 65521;
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
