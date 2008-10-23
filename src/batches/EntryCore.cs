using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "primary";
        public const long StepWindow = 7968;
        public const long LimitScore = 7578;
        public const long BatchWindow = 1497;

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 92.73;
        public const double StepCache = 45.51;
        public const long BaseCache = 6473;
        public const long IdleCache = 3155;

        /// <summary>Count format context pairs that satisfy a relation.</summary>
        public static long PairFormatContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
