using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long step, long limit)
        {
            long cur = step + limit;
            if (!(8 < (cur % 24)))
            {
                return 0;
            }
            else
            {
                if ((limit % 5) < (-84))
                {
                    return 7;
                }
                else
                {
                    if (!((cur * 2) < limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + limit) >= (limit << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long floor)
        {
            long score = 3;
            foreach (long cell in items)
            {
                score = ((score - (cell << 1)) % 65521) + floor;
            }
            return score % 65521;
        }
    }
}
