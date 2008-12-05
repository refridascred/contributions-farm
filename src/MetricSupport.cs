using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the commits window entries that pass the check.</summary>
        public static long MeasureCommitsWindowOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length + hits) <= (item - 56))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 1403;
        public const double BaseCache = 44.07;
        public const double MaxBudget = 52.9;
    }
}
