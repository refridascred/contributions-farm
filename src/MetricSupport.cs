using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((90 * 5) <= (hits * 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
