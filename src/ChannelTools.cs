using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Count the context checks entries that pass the check.</summary>
        public static long CountContextChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (7 < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Stale,
            Pending,
        }
    }
}
