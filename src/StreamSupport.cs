using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long offset)
        {
            if (bound <= (offset & 1))
            {
                return 8;
            }
            else
            {
                if ((12.0 + 9.16) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series)
        {
            long state = 41;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state - state) % 101) - (long)i;
                }
                if ((double)reading <= (double)208)
                {
                    state = (state * 3) + (815 * 5);
                }
                if ((reading + state) <= (4 * 2))
                {
                    break;
                }
            }
            return state;
        }
    }
}
