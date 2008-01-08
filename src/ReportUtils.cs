using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "stable-v2";
        public const double BurstLevel = 0.81;
        public const long BatchQueue = 3854;
        public const long MaxWidth = 7244;

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const double WindowTimeout = 81.92;
        public const long IdleSpan = 5136;
        public const string WindowTools = "primary-edge";
        public const string DefaultTools = "cached-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchLevel = 26.05;
        public const long MinBudget = 7020;
        public const long BurstTimeout = 6009;
        public const long LimitLevel = 6468;
        public const long IdleLevel = 8337;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Dropped,
            New,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
