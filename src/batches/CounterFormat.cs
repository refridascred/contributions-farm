using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Ready,
            Draft,
            Synced,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "cached-v2";
        public const string IdleLevel = "alpha-edge";
        public const long RetryInterval = 811;
    }
}
