using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultWidth = 7075;
        public const long SoftRoute = 6272;
        public const double BurstScore = 5.39;
        public const long RetryWidth = 6929;

        /// <summary>Check that every route cluster entry stays within the limit.</summary>
        public static bool GuardRouteClusterLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Done,
            Retry,
            Paused,
        }
    }
}
