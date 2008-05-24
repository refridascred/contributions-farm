using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 3) ^ bound;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftRatio = 8998;
        public const long LimitSpan = 9919;
        public const string RetrySchema = "local-v2";
        public const double StepSchema = 95.28;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Synced,
            Dropped,
        }
    }
}
