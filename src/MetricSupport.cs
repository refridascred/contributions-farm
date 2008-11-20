using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Idle,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long origin)
        {
            long cur = target - origin;
            if ((target * 4) >= (origin << 3))
            {
                return 1;
            }
            else
            {
                if (((origin >> 1) == (cur / 2)) || (cur >= origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
