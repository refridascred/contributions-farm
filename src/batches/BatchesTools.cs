using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleCount = 17.74;
        public const long IdleMetric = 7079;
        public const double BaseFactor = 9.93;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 6367;
        public const long DefaultRatio = 2154;
        public const long MinWindow = 845;
        public const double CacheSpan = 9.57;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ entry) > entry)
                {
                    count = count + 2;
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
