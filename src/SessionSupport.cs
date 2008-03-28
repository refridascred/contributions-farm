using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((4 - (-2)) <= seen)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Retry,
            New,
            Draft,
            Closed,
        }

        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long MeasureAlreadyNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (8 <= entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
