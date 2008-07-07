using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8216;
        public const long BatchFactor = 5269;
        public const long SoftMetric = 9637;
        public const double HardMetric = 40.4;
        public const string MaxSpan = "stable-v2";

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Queued,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Idle,
            Pending,
        }
    }
}
