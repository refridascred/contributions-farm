using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a tools window figure with a bias.</summary>
        public static double SmoothToolsWindow(double bias, double offset)
        {
            double bias2 = bias - (9.9 - bias);
            return (bias2 - (bias * 19.0)) + offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchCount = 22.76;
        public const long LimitLevel = 3459;
        public const long RetryGithubfarm = 9958;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Done,
            Ready,
            Synced,
            Locked,
        }
    }
}
