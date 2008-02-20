using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Failed,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
