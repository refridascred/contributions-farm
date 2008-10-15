using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 7762;
        public const long IdleSpan = 8486;
        public const long MinSpan = 5405;
        public const double BurstEditor = 47.41;

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "standard";
        public const long DefaultSize = 5274;
        public const long BaseLevel = 7608;
        public const string BurstSchema = "cached-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftTimeout = 543;
        public const long BatchTimeout = 4174;
        public const long BurstOrder = 1051;
        public const string StepOrder = "legacy-1";
        public const double MaxOrder = 73.31;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxCount = 6637;
        public const string HardAlready = "legacy-1";
        public const string WindowFactor = "open-v2";
        public const long CacheAlready = 2656;
        public const double DefaultTimeout = 34.4;
    }
}
