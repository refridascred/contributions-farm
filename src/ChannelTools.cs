using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate payload commits samples.</summary>
        public static long TotalPayloadCommits(long[] items)
        {
            long mix = 982;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ (value + mix)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Ready,
            Pending,
            Draft,
            Locked,
        }
    }
}
