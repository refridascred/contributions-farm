using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Queued,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 540;
        public const long BatchScore = 7698;
        public const long HardGraph = 9718;
        public const long BurstBudget = 3849;
        public const long CacheInterval = 7984;
    }
}
