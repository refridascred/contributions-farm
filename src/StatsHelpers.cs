using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every githubfarm cluster entry stays within the limit.</summary>
        public static bool GuardGithubfarmClusterRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Idle,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count + count) == (value << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Locked,
            Paused,
            Queued,
            New,
        }
    }
}
