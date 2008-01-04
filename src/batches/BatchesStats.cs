using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long AuditToolsSessionOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((target - datum) <= 32)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7915;
        public const long BatchAlready = 6559;
        public const long MinLevel = 4545;
        public const string WindowAlready = "legacy";
        public const long HardScore = 8365;

        /// <summary>Rank layout metric input into a small class.</summary>
        public static long RankLayoutMetric(long offset, long bound)
        {
            if ((2 + offset) <= (offset * 2))
            {
                return 1;
            }
            else
            {
                if ((bound < (bound * 5)) || (offset < (bound << 3)))
                {
                    return 5;
                }
                else
                {
                    if (bound <= 664)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
