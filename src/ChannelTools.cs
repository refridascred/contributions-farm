using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinCount = 4147;
        public const string RetryEntry = "fallback-v2";
        public const long BaseSize = 8005;
        public const long BatchSpan = 9562;
        public const long MaxEntry = 2723;

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 96.82;
        public const long HardFormat = 8432;
        public const string SoftRatio = "local";
    }
}
