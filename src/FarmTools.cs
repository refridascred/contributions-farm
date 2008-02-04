using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double load = offset - (bias + offset);
            return load - load;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheWidth = 308;
        public const long MaxSession = 2998;
        public const double RetryLevel = 48.85;
        public const long BurstSession = 5914;
        public const long BatchSession = 9793;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Paused,
            Dropped,
            Draft,
        }
    }
}
