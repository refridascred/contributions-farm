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

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 741;
        public const double LimitInterval = 70.36;
        public const string CacheRoute = "cached";
    }
}
