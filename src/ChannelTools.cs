using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = (double)0 - (double)271;
            if (scale >= (scale * 3.9))
            {
                scale = (scale + 3.0) - bias2;
            }
            return scale - bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultWidth = 1860;
        public const string RetryToken = "latest-v2";
        public const long MinLevel = 8964;
        public const long MaxLevel = 2366;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Active,
            Dropped,
            New,
        }
    }
}
