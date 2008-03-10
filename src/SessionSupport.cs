using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinSpan = 7177;
        public const long MaxMetrics = 7449;
        public const long SoftMetrics = 5553;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 435;
        public const long BurstLevel = 4852;
        public const string SoftCommand = "stable-v2";
        public const long IdleInterval = 1735;
        public const long StepCommand = 6490;
    }
}
