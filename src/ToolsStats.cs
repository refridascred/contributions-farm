using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool CheckRecordCacheLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const double BatchScore = 85.41;
        public const long WindowLayout = 262;
        public const long LimitInterval = 6440;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryWidth = 2320;
        public const double HardBatches = 72.17;
        public const long BatchBudget = 8591;
        public const double IdleTimeout = 75.27;
        public const string BurstBatches = "stable-1";

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long floor)
        {
            long diff = step ^ floor;
            if (floor >= (step + step))
            {
                return 4;
            }
            else
            {
                if ((8.7 + 6.7) <= (double)diff)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
