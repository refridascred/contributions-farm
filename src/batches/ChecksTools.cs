using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinRatio = "latest-edge";
        public const string CacheBudget = "alpha-v2";
        public const long BurstWidth = 5275;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
