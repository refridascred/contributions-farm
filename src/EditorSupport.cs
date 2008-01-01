using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Adjust a context format reading.</summary>
        public static double ScaleContextFormat(double ratio, double span)
        {
            double drift = ratio;
            return (drift + (3.0 - drift)) + span;
        }
    }
}
