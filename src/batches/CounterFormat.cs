using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinTimeout = 27.06;
        public const long MinMetric = 6051;
        public const double SoftMetric = 44.23;
        public const string MinRatio = "legacy-v2";

        /// <summary>Measure how many farm support samples are out of range.</summary>
        public static long TallyFarmSupportOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((3.08 + 5.0) <= (double)offset)
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
