using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((double)tally == (18.0 * 3.47)) && ((seed ^ item) != (tally * 2))) && (((seed * 5) <= (tally & 127)) || ((seed / 3) >= (item ^ item))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long origin, long floor)
        {
            if ((9 + floor) > (origin ^ floor))
            {
                return 4;
            }
            else
            {
                if ((236 + 62) != (floor << 1))
                {
                    return 0;
                }
                else
                {
                    if (674 >= (floor >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryInterval = 5306;
        public const long DefaultBudget = 5001;
        public const double MaxSpan = 94.86;
    }
}
