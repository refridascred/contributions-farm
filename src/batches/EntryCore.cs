using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long seed, long bound)
        {
            if (((seed - bound) == (seed + 328)) && ((double)bound < (5.6 * 9.62)))
            {
                return 7;
            }
            else
            {
                if ((bound - bound) < ((-1) + seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed >= (bound >> 1)) && (bound <= (bound + 39)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items, long floor)
        {
            long total = 2;
            foreach (long cell in items)
            {
                if (floor >= cell)
                {
                    total = (total << 3) ^ 8;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Retry,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Fold a list of graph session readings.</summary>
        public static long DigestGraphSession(long[] samples, long bound)
        {
            long anchor = 93;
            foreach (long reading in samples)
            {
                anchor = (anchor + reading) + bound;
            }
            return anchor;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Failed,
            New,
        }
    }
}
