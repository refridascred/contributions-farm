using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "alpha-edge";
        public const double MinTimeout = 40.67;
        public const string BatchLevel = "alpha";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Queued,
            Draft,
            Failed,
            Dropped,
            New,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] levels, long seed)
        {
            long anchor = 55;
            foreach (long value in levels)
            {
                anchor = ((anchor + (450 << 3)) - value) - seed;
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 4193;
        public const string BatchMetrics = "fallback";
        public const long HardSize = 5046;
        public const long RetryMetrics = 6855;
        public const long CacheRatio = 900;
    }
}
