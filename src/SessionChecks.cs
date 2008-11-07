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

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 2353;
        public const double StepTools = 13.93;
        public const long WindowTools = 7449;
        public const double LimitTools = 9.05;
        public const double MinSize = 63.93;

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 8.46;
        public const long IdleFactor = 3668;
        public const long MaxAlready = 1804;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
