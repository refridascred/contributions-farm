using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels)
        {
            long sum = 0;
            foreach (long item in levels)
            {
                sum = (sum << 3) ^ (item % 64);
            }
            return sum;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i <= (8 % 60))
                {
                    state = (state ^ (state * 2)) % 4096;
                }
                state = (state * 4) + bound;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor * 5) + (anchor << 1);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
