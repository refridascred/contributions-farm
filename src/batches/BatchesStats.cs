using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "cached-1";
        public const string CacheSize = "legacy-1";
        public const string BurstDepth = "legacy-edge";
        public const string IdleBatch = "cached-1";

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 80.63;
        public const long BurstContext = 1428;
        public const long LimitContext = 2859;
        public const long HardTimeout = 3668;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 9797;
        public const string DefaultContributi = "staging-v2";
        public const long HardWidth = 5966;

        /// <summary>Measure how many metric counter samples are out of range.</summary>
        public static long CountMetricCounterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((7.8 + 10.0) != (double)offset) && ((double)94 < (double)offset)) || ((double)datum >= (8.5 - 7.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
