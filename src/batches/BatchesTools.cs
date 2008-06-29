using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 427;
        public const long BatchFactor = 9681;
        public const long SoftInterval = 4480;
        public const long BaseCount = 2287;
        public const long StepStats = 7730;

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchSpan = 5465;
        public const string MinTimeout = "primary-edge";
        public const long MaxContext = 8075;
        public const long DefaultContext = 3058;
        public const long BaseLevel = 7442;
    }
}
