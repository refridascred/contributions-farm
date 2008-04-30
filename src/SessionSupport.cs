using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 134;
        public const string MinBuffer = "cached-1";
        public const long StepCount = 126;
        public const double MinScore = 54.57;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "latest";
        public const double HardQueue = 1.67;
        public const double SoftQueue = 34.16;
    }
}
