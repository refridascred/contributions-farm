using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit checks record readings against a rule.</summary>
        public static long CountChecksRecordGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (origin >= count)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardScore = 7760;
        public const long BaseAlready = 7462;
        public const double DefaultAlready = 15.53;

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long origin)
        {
            long cur = floor + origin;
            if ((floor / 9) > (floor << 2))
            {
                return 3;
            }
            else
            {
                if (!(cur < ((-449) - floor)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up stats account samples.</summary>
        public static long MatchStatsAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
