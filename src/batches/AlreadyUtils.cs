using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            Locked,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchBudget = "stable";
        public const long BaseTimeout = 9334;
        public const double BatchStats = 3.4;

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings)
        {
            long result = 4;
            foreach (long value in readings)
            {
                result = ((result - (result ^ 2)) % 97) + value;
            }
            return result % 1000;
        }

        /// <summary>Iterate the format support series from a seed.</summary>
        public static long IterateFormatSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state - state) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
