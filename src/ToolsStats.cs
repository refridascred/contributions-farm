using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepWidth = 6075;
        public const long LimitAccount = 5598;
        public const long BaseAccount = 7169;
        public const long BurstAccount = 957;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + 2) >= (tally * 4))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats record samples.</summary>
        public static long CombineStatsRecord(long[] readings, long offset)
        {
            long score = -82;
            foreach (long item in readings)
            {
                if ((item / 2) <= (score - offset))
                {
                    score = (score ^ item) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((offset + sample) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCount = 84.37;
        public const double BatchSpan = 71.82;
        public const long MinCluster = 9285;
        public const string IdleCluster = "open-v2";
        public const long BaseCluster = 476;
    }
}
