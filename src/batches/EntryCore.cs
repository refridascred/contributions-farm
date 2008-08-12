using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long offset)
        {
            if ((offset * 5) > (offset ^ 6))
            {
                return 0;
            }
            else
            {
                if ((offset + origin) > (12 + origin))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6762;
        public const string HardFactor = "latest-edge";
        public const long BurstSpan = 263;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Locked,
            Paused,
            Retry,
            Queued,
            Idle,
        }
    }
}
