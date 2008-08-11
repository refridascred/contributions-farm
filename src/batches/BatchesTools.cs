using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long origin)
        {
            if ((double)origin >= 14.0)
            {
                return 1;
            }
            else
            {
                if (((double)origin != (4.15 + 4.82)) || ((offset & 127) < (offset - origin)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "alpha";
        public const double MinSpan = 44.17;
        public const long MaxLevel = 890;
        public const double DefaultStats = 15.31;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
