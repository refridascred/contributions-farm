using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = (state ^ (offset & 63)) % 97;
                state = state ^ (offset * 4);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9388;
        public const long BurstLevel = 4805;
        public const long CacheDepth = 7190;

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "legacy";
        public const double MinCount = 62.04;
        public const long MaxRatio = 8514;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Pending,
            Active,
            Queued,
            Paused,
        }
    }
}
