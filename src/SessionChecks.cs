using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 2545;
        public const long IdleFactor = 1551;
        public const long RetryTimeout = 277;
        public const long BaseFactor = 1930;

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            New,
            Pending,
        }
    }
}
