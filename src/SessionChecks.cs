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

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultDepth = 8270;
        public const long DefaultWindow = 5100;
        public const long BaseWindow = 2661;
        public const long SoftWindow = 8368;
    }
}
