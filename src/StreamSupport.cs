using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((double)73 == (double)count))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Done,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] readings, long seed)
        {
            long acc = 45;
            foreach (long sample in readings)
            {
                if ((8.97 / 9.0) > (double)seed)
                {
                    acc = (((acc * 3) + (8 - acc)) % 255) ^ sample;
                }
            }
            return acc;
        }
    }
}
