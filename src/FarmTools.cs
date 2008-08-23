using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((9 >= state) && ((2.9 / 9.0) >= (double)(long)i))
                {
                    state = (state - ((long)i + state)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (origin + (long)i);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (88 >= item)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }
    }
}
