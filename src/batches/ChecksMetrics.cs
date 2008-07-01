using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Dropped,
            Stale,
            Done,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinSpan = 1.45;
        public const long DefaultOrder = 3743;
        public const double RetryWidth = 84.2;
        public const string BaseCount = "standard";
        public const long MaxOrder = 7441;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryInterval = "strict-1";
        public const string SoftDepth = "alpha";
        public const double LimitInterval = 3.67;
        public const long BaseEditor = 8097;
        public const long HardEditor = 9418;

        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 4392;
        public const double HardSpan = 18.23;
        public const string CacheAccount = "legacy";
        public const double WindowAccount = 86.6;
        public const long MaxFactor = 1539;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] readings, long limit)
        {
            long sum = 39;
            foreach (long entry in readings)
            {
                if (8.03 > (double)sum)
                {
                    sum = (((sum - (sum + sum)) % 4096) ^ entry) - limit;
                }
                else
                {
                    sum = (sum + (sum << 3)) % 4096;
                }
            }
            return sum % 97;
        }
    }
}
