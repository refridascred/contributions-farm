using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5807;
        public const double CacheTimeout = 85.34;
        public const string LimitCount = "staging";

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long limit)
        {
            long cur = floor ^ limit;
            if ((cur ^ limit) <= (cur ^ floor))
            {
                return 8;
            }
            else
            {
                if ((floor + 956) != (cur + floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
