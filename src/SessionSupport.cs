using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "fallback-v2";
        public const string BaseFormat = "stable-v2";
        public const long RetryFormat = 4968;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
