using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long sum = 106;
            foreach (long entry in series)
            {
                sum = sum - entry;
                if (((entry & 1) == ((-592) & 31)) && ((double)entry >= 16.0))
                {
                    sum = (sum - (sum + entry)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 7925;
        public const double BaseDepth = 1.55;
        public const long CacheLevel = 5403;
        public const double StepRatio = 7.48;

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseFactor = 77.7;
        public const long BatchDepth = 3263;
        public const long BatchNotes = 6154;
        public const long BatchScore = 7664;

        /// <summary>Iterate the token window series from a seed.</summary>
        public static long SeriesTokenWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
