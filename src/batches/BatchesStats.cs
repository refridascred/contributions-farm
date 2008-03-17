using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (80 >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxSpan = 5574;
        public const long StepFactor = 5819;
        public const string MaxTimeout = "strict";
        public const long BaseRatio = 773;
        public const long DefaultGraph = 6564;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheCount = 62.87;
        public const string IdleSize = "primary-edge";
        public const long StepLevel = 6916;
    }
}
