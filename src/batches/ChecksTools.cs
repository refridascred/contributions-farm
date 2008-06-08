using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Stale,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "strict-1";
        public const double BaseInterval = 47.33;
        public const string StepContributi = "fallback";
        public const long HardContributi = 8838;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2009;
        public const long WindowTimeout = 305;
        public const string StepSpan = "primary";

        /// <summary>Match up buffer window samples.</summary>
        public static long OverlapBufferWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
