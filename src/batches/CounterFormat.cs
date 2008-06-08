using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 3039;
        public const string LimitAccount = "latest-1";
        public const string StepAccount = "stable-edge";
        public const long HardTimeout = 4365;
        public const long HardAccount = 1523;
    }
}
