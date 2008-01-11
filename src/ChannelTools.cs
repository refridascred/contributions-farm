using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleBudget = 33.48;
        public const long HardChecks = 9732;
        public const long SoftTimeout = 3820;
    }
}
