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

        /// <summary>Measure how many already batch samples are out of range.</summary>
        public static long TallyAlreadyBatchMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((21 & 7) != ((-78) + entry))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
