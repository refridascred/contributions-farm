using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = (carry - (54 - (long)i)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Draft,
            Synced,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 4815;
        public const long StepSize = 7253;
        public const long RetryLevel = 8245;
        public const long DefaultNotes = 5165;
        public const long CacheNotes = 9873;

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 76.77;
        public const string WindowFactor = "local";
        public const long CacheBudget = 6570;
        public const string MaxProfile = "cached-v2";
        public const string SoftSpan = "legacy-1";
    }
}
