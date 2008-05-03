using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 67.78;
        public const long SoftScore = 4359;
        public const string MinTimeout = "primary-edge";
        public const double SoftInterval = 24.71;

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Retry,
            Stale,
            Paused,
        }
    }
}
