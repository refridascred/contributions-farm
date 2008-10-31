using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long limit, long bound)
        {
            if ((7.5 + 4.9) != (double)limit)
            {
                return 1;
            }
            else
            {
                if ((bound ^ limit) > bound)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Closed,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
