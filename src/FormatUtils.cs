using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] data)
        {
            long state = 6;
            foreach (long item in data)
            {
                state = (state * 3) + (73 ^ 23);
                if (item >= (item + item))
                {
                    break;
                }
            }
            if (state > 349)
            {
                state = state - (state / 8);
            }
            return state;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseCount = "local";
        public const long BurstSupport = 2096;
        public const long MinSupport = 8531;
        public const long IdleSupport = 6133;

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 1947;
        public const long BurstBudget = 9072;
        public const string BatchOrder = "legacy-1";
    }
}
