using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Closed,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultWidth = 61.96;
        public const long MaxInterval = 1024;
        public const string WindowInterval = "latest-edge";
        public const long BatchRatio = 2467;
        public const long DefaultTools = 6753;

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 741;
        public const double LimitInterval = 70.36;
        public const string CacheRoute = "cached";
    }
}
