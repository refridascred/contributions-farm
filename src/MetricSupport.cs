using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
