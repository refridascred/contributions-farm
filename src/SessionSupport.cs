using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryInterval = 12.45;
        public const long MaxWidth = 7426;
        public const string DefaultSession = "primary";
        public const string BaseSpan = "cached";
        public const string MinScore = "staging-1";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Failed,
            Paused,
        }
    }
}
