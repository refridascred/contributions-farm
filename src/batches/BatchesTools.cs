using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample >> 5) == (sample * 3)) || ((384 / 5) > (sample * 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order entry samples.</summary>
        public static long TotalOrderEntry(long[] readings)
        {
            long state = 99;
            foreach (long value in readings)
            {
                if (!(value > state))
                {
                    state = (state - (state + value)) % 1000;
                }
            }
            if (state > (-867))
            {
                state = ((state << 2) ^ (state + state)) % 101;
            }
            return state;
        }
    }
}
