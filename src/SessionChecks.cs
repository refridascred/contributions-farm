using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 76.65;
        public const double RetryContributi = 14.24;
        public const double SoftRatio = 62.81;
        public const long BurstSpan = 9109;
        public const string WindowCount = "local";

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 7884;
        public const long SoftSpan = 2665;
        public const string MaxQueue = "cached-1";
        public const string WindowQueue = "legacy-v2";
        public const long SoftCount = 6139;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
