using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next format checks value from a seed.</summary>
        public static long StepFormatChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            New,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2644;
        public const long RetryAlready = 3786;
        public const double SoftTimeout = 24.82;
        public const double MaxInterval = 33.2;
        public const double DefaultWidth = 59.07;
    }
}
