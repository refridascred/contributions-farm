using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double offset)
        {
            double bias = (ratio / 6.0) + 15.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSpan = 2832;
        public const long MaxScore = 7896;
        public const double RetryOrder = 52.44;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Synced,
            Locked,
            Stale,
            Closed,
        }
    }
}
