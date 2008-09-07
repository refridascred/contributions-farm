using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 7536;
        public const double WindowContext = 63.47;
        public const string WindowScore = "standard";
        public const long LimitDepth = 6623;
        public const long StepBudget = 1295;

        /// <summary>Measure how many checks channel samples are out of range.</summary>
        public static long TallyChecksChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (0 <= (391 + hits))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
