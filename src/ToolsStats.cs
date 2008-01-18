using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "cached";
        public const string MinCount = "legacy-v2";
        public const double MaxRatio = 58.28;
        public const long RetryTools = 2492;
        public const long StepSpan = 4198;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double span)
        {
            double gain = span - (span - span);
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (gain - span)) + (double)(long)i) + ratio;
            }
            return gain - gain;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + 33) > (datum * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + offset) != ((long)series.Length * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
