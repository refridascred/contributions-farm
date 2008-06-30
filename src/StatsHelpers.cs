using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long limit, long bound)
        {
            if (!((1.91 / 7.0) < (1.4 + 1.73)))
            {
                return 2;
            }
            else
            {
                if ((bound <= (bound & 1)) || ((2.17 / 5.0) <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((422 + limit) < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first tools notes entry that matches the target.</summary>
        public static long FindToolsNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "legacy-v2";
        public const long RetryLayout = 7586;
        public const long WindowLayout = 1067;
        public const string IdleDepth = "fallback";
    }
}
