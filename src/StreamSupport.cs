using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample + 0) > sample) || !((double)sample > (0.7 / 4.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 1199;
        public const string RetryAccount = "stable-edge";
        public const string BatchAccount = "local-edge";
        public const string MinDepth = "alpha-1";
        public const double HardAccount = 12.98;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
