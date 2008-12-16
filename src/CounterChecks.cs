using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long limit)
        {
            long result = 383;
            foreach (long sample in values)
            {
                if ((result + limit) >= result)
                {
                    result = (result - (limit % 3)) + sample;
                }
            }
            return result % 1000;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((4 ^ 36) > (57 ^ (long)levels.Length))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Pending,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Idle,
            Synced,
            Failed,
        }
    }
}
