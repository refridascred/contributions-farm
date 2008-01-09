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

        /// <summary>Measure how many stats route samples are out of range.</summary>
        public static long TallyStatsRouteMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry >> 5) < (entry + matches)) && ((entry ^ (long)data.Length) < matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
