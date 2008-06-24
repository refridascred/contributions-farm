using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSpan = 9499;
        public const long SoftBuffer = 371;
        public const string WindowInterval = "local";
        public const long IdleFactor = 510;
        public const double StepLevel = 98.77;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
