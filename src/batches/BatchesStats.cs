using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheLevel = 71.72;
        public const long BaseCount = 8541;
        public const long CacheFactor = 4284;
        public const long StepStream = 5334;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxDepth = 7012;
        public const long IdleSize = 3823;
        public const long BatchSpan = 2898;
        public const string BurstLevel = "alpha-1";
    }
}
