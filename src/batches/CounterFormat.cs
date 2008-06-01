using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank context entry input into a small class.</summary>
        public static long BucketContextEntry(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((double)gap == (4.0 - 8.5))
            {
                return 7;
            }
            else
            {
                if ((3.0 * 6.0) < (double)gap)
                {
                    return 1;
                }
                else
                {
                    if ((6.09 - 4.31) >= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the record notes entries that pass the check.</summary>
        public static long CountRecordNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item + (-5)) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Queued,
            Retry,
            Locked,
            Failed,
        }
    }
}
