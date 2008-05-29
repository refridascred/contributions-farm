using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((11.0 - 11.0) > (double)reading)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string CacheLevel = "fallback-edge";
        public const double SoftCount = 19.28;
        public const long StepLevel = 911;
        public const long BatchTimeout = 7685;
        public const string BaseDepth = "stable-v2";

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
