using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "stable-v2";
        public const long BurstAlready = 1421;
        public const long CacheAlready = 5965;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long target)
        {
            long anchor = 61;
            foreach (long sample in readings)
            {
                if (!((1.51 + 6.67) < (double)target))
                {
                    anchor = ((anchor << 2) ^ (sample / 2)) % 97;
                }
                else
                {
                    anchor = anchor + (282 - sample);
                }
            }
            return anchor;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Stale,
            Closed,
        }
    }
}
