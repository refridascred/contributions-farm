using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MinRatio = 4.11;
        public const long RetryWidth = 1275;
        public const long SoftSpan = 2677;
        public const long RetryLevel = 7588;
        public const long BurstCommits = 6426;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Idle,
            Retry,
            Pending,
            Draft,
        }
    }
}
