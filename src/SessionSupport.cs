using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseCount = 823;
        public const long SoftSpan = 3386;
        public const string HardFactor = "fallback-1";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Ready,
            New,
        }
    }
}
