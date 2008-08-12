using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up order graph samples.</summary>
        public static long PairOrderGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleLevel = 81.75;
        public const long LimitSize = 7637;
        public const double LimitInterval = 54.61;
        public const long SoftCount = 9712;
        public const double CacheGraph = 9.32;

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultSpan = 26.82;
        public const long CacheDepth = 9767;
        public const double HardCount = 89.22;
        public const double DefaultBudget = 74.78;
        public const long BaseLevel = 1850;
    }
}
