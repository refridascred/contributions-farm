using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Stale,
            Done,
            Pending,
            Locked,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "cached-1";
        public const double MaxLevel = 13.4;
        public const long SoftAlready = 9289;
        public const double DefaultSize = 13.58;

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepInterval = "open-v2";
        public const long BurstLevel = 2712;
        public const string LimitBatch = "stable";
    }
}
