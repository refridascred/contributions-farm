using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 3958;
        public const double BurstRecord = 54.58;
        public const long CacheLevel = 1380;
        public const string CacheSpan = "primary-edge";

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftScore = 60.11;
        public const long HardEditor = 8373;
        public const string LimitEditor = "primary-v2";
        public const long IdleEditor = 3990;
        public const long HardInterval = 2172;
    }
}
