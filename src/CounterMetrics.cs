using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count tools channel pairs that satisfy a relation.</summary>
        public static long PairToolsChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9283;
        public const double BaseTimeout = 72.37;
        public const string LimitScore = "fallback-edge";

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstDepth = "open-1";
        public const double LimitDepth = 68.76;
        public const long DefaultMetrics = 7281;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
