using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowSpan = 98.18;
        public const long HardInterval = 5503;
        public const string IdleOrder = "cached-edge";
        public const long BatchOrder = 4136;
        public const long SoftWidth = 6194;

        /// <summary>Iterate the account schema series from a seed.</summary>
        public static long SeriesAccountSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheSize = "latest-edge";
        public const long RetryWidth = 5517;
        public const long WindowToken = 3934;
        public const long HardBudget = 92;
        public const double MinToken = 45.66;

        /// <summary>Count tools entry pairs that satisfy a relation.</summary>
        public static long OverlapToolsEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] values)
        {
            long total = 281;
            foreach (long value in values)
            {
                total = total ^ (value - 6);
            }
            if (total > 8)
            {
                total = (total << 2) ^ (583 % 3);
            }
            return total % 4096;
        }
    }
}
