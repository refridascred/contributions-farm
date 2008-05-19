using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up notes report samples.</summary>
        public static long PairNotesReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftRatio = 287;
        public const long RetryDepth = 6318;
        public const long DefaultCommits = 1770;
        public const long StepCommits = 4169;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long target)
        {
            long offset = floor ^ target;
            if ((offset ^ floor) >= floor)
            {
                return 8;
            }
            else
            {
                if ((double)offset < (7.7 - 2.58))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (target - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset != (4.0 + 3.6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
