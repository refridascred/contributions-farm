using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Active,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((6.75 - 8.55) < (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitDepth = 9945;
        public const long HardFarm = 9986;
        public const long IdleTimeout = 5214;
        public const long BatchDepth = 4519;
    }
}
