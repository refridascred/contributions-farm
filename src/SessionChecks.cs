using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinInterval = 3671;
        public const long BaseTools = 8696;
        public const double CacheTools = 7.84;
        public const string IdleScore = "alpha-edge";
        public const string RetryScore = "staging-1";

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 1.51;
        public const string WindowToken = "stable-edge";
        public const long RetryToken = 1891;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Dropped,
            Retry,
        }
    }
}
