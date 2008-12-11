using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Idle,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Closed,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 > (weight2 * 3.5))
            {
                weight2 = weight2 + offset;
            }
            return weight2 + weight;
        }
    }
}
