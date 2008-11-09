using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally << 2) != (entry % 2)) || (74 <= (tally + entry)))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 38.29;
        public const double CacheFactor = 85.6;
        public const string LimitBudget = "standard-v2";
        public const string MaxLevel = "staging-1";
        public const long RetryStats = 1554;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Match up graph editor samples.</summary>
        public static long MatchGraphEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
