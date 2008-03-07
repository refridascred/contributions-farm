using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double bias2 = (bias + floor) * 12.0;
            if (bias2 >= (double)3)
            {
                bias2 = bias2 + floor;
            }
            return bias2 - floor;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Stale,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Retry,
            Failed,
            Closed,
            Ready,
        }
    }
}
