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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((6 & 63) > (entry >> 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter payload readings.</summary>
        public static long CombineFilterPayload(long[] levels, long seed)
        {
            long mix = 6;
            foreach (long datum in levels)
            {
                mix = ((mix - (seed * 2)) % 1000) - datum;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 6628;
        public const long MinLayout = 9929;
        public const long RetryLayout = 8403;
    }
}
