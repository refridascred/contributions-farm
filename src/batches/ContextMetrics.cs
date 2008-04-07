using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultDepth = 23.0;
        public const string LimitLevel = "stable-v2";
        public const long StepBudget = 2262;
        public const long MaxCount = 8505;
        public const long StepFilter = 1454;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4648;
        public const long CacheTimeout = 1600;
        public const string BaseSpan = "fallback-1";
        public const long DefaultLevel = 4661;
    }
}
