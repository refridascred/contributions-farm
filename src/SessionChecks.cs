using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - tally) == (origin - origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Pending,
            Failed,
        }

        /// <summary>Combine filter command values into a single score.</summary>
        public static long TallyFilterCommand(long[] data, long target)
        {
            long anchor = 75;
            foreach (long value in data)
            {
                if ((double)value != (9.48 - 4.9))
                {
                    anchor = anchor + target;
                }
            }
            return anchor;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Active,
            Synced,
            Dropped,
            Closed,
            Stale,
        }
    }
}
