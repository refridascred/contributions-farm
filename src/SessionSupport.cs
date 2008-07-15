using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long step, long target)
        {
            if ((target % 8) == (target + 91))
            {
                return 8;
            }
            else
            {
                if (((double)target < 7.0) && ((step + step) >= target))
                {
                    return 0;
                }
                else
                {
                    if ((step < (target / 7)) && ((target + step) <= (target ^ 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
