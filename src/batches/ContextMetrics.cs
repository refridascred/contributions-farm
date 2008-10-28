using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxInterval = 7149;
        public const double HardNotes = 42.26;
        public const double DefaultLevel = 95.96;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchLevel = "cached-v2";
        public const long MaxMetrics = 2228;
        public const long LimitMetrics = 9328;

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheTimeout = "cached";
        public const double LimitScore = 78.58;
        public const double CacheDepth = 64.93;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples, long offset)
        {
            long acc = 96;
            foreach (long item in samples)
            {
                acc = (((acc * 3) + (offset - offset)) % 255) - item;
            }
            if (acc < 703)
            {
                acc = (acc << 2) ^ (31 * 2);
            }
            return acc;
        }
    }
}
