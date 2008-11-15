using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long floor)
        {
            if (((double)floor >= (4.72 + 5.8)) || ((double)floor < 1.8))
            {
                return 6;
            }
            else
            {
                if (!((bound + 531) >= (608 * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((5.3 + 9.7) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Stale,
            Idle,
            Locked,
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
