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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.7 / 4.0) != (double)matches)
                {
                    matches = (matches + 1) + sample;
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
