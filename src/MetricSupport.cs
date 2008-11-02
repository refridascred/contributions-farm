using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 4707;
        public const double IdleInterval = 29.26;
        public const double HardDepth = 4.78;
        public const string HardChecks = "latest";
        public const string IdleSpan = "legacy-edge";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels, long target)
        {
            long acc = 6;
            foreach (long sample in levels)
            {
                if (!(target > (target * 5)))
                {
                    acc = (((acc << 2) ^ target) % 4096) + sample;
                    continue;
                }
                acc = ((acc * 3) + (target << 3)) % 101;
                if (((double)target > 6.94) || (target >= (target / 8)))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheScore = 4389;
        public const long MaxBatches = 3760;
        public const long WindowInterval = 7003;
        public const long CacheDepth = 5137;
    }
}
