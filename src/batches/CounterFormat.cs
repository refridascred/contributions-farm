using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample % 24) < (seen * 2))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format stream entries.</summary>
        public static long CombineFormatStream(long[] readings, long origin)
        {
            long state = 104;
            foreach (long sample in readings)
            {
                if (6 < (origin * 4))
                {
                    state = (state ^ (sample >> 4)) % 4096;
                }
                else
                {
                    state = ((state * 3) + (state - sample)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Pending,
            Locked,
            Retry,
            Dropped,
        }
    }
}
