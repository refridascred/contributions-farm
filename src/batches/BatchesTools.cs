using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + 801) < (count % 64))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultSpan = 32.66;
        public const long RetryMetric = 9848;
        public const long HardScore = 8102;
        public const long MinMetric = 1904;
        public const long MaxMetric = 9640;
    }
}
