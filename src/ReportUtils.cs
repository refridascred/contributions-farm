using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Ready,
            Locked,
            New,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] values)
        {
            long score = 62;
            foreach (long item in values)
            {
                if ((2.42 / 8.0) < (double)item)
                {
                    score = score + (score ^ score);
                }
            }
            return score % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxDepth = 88.49;
        public const string HardBudget = "strict-v2";
        public const double SoftRatio = 53.16;
    }
}
