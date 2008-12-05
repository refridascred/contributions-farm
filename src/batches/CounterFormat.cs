using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((5.6 * 3.71) < (double)state)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Failed,
            Synced,
            Dropped,
        }
    }
}
