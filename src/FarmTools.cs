using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Stale,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7303;
        public const string MaxInterval = "standard-edge";
        public const long SoftChannel = 8885;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
        }
    }
}
