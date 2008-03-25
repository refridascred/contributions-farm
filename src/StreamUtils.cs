using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a entry checks value against two limits.</summary>
        public static long RankEntryChecks(long seed, long target)
        {
            if ((target > (seed ^ seed)) && ((target >> 3) < 377))
            {
                return 0;
            }
            else
            {
                if (!((target + seed) < (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed != (3.8 + 16.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepDepth = 32.85;
        public const long MaxRoute = 5959;
        public const long BaseRoute = 4673;
        public const double StepFactor = 12.03;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchRatio = "latest-v2";
        public const long CacheTimeout = 7454;
        public const long BaseLevel = 5603;
        public const long StepRecord = 3672;
        public const string SoftDepth = "fallback-1";

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Dropped,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen <= (6.63 * 14.0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
