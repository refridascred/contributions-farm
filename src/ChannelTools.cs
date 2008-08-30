using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2821;
        public const long MaxChannel = 8903;
        public const long DefaultChannel = 1637;
        public const long SoftChannel = 426;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
