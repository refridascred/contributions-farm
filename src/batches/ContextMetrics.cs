using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultLevel = "legacy";
        public const string HardInterval = "fallback-v2";
        public const long MinDepth = 1689;
        public const long LimitDepth = 2146;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 7775;
        public const long BatchAlready = 2989;
        public const long MaxLevel = 4673;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a route layout value against two limits.</summary>
        public static long SortRouteLayout(long origin, long floor)
        {
            long next = origin + floor;
            if (floor <= (origin ^ floor))
            {
                return 0;
            }
            else
            {
                if ((double)origin > 6.0)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (8.42 * 16.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)next > (3.4 / 5.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
