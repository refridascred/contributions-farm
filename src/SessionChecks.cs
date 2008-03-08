using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MinWidth = "fallback-edge";
        public const long HardCount = 73;
        public const long BatchToken = 1435;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every buffer already entry stays within the limit.</summary>
        public static bool GuardBufferAlreadyRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
