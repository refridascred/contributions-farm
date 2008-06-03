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

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public double Token { get; set; }
            public long Score { get; set; }
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
