using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryScore = 14.06;
        public const double BurstSession = 15.59;
        public const double HardSession = 36.44;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            New,
            Pending,
        }
    }
}
