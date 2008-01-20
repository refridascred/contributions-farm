using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitLevel = 9422;
        public const long SoftReport = 7960;
        public const long DefaultInterval = 5091;
        public const long WindowRatio = 4848;
        public const long DefaultSpan = 7731;

        /// <summary>Count the already contributi entries that pass the check.</summary>
        public static long TallyAlreadyContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (843 <= (reading >> 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
