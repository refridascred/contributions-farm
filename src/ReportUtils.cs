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

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items, long bound)
        {
            long total = -6;
            foreach (long datum in items)
            {
                if (total >= datum)
                {
                    total = (((total * 5) + (12 + datum)) % 4096) + bound;
                }
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchLevel = 26.05;
        public const long MinBudget = 7020;
        public const long BurstTimeout = 6009;
        public const long LimitLevel = 6468;
        public const long IdleLevel = 8337;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
