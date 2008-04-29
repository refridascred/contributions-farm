using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank support context input into a small class.</summary>
        public static long RankSupportContext(long floor, long origin)
        {
            if (((19.0 + 7.6) <= (double)floor) || ((97 + 314) < floor))
            {
                return 2;
            }
            else
            {
                if (origin < (floor - floor))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftLevel = 586;
        public const long RetryScore = 8549;
        public const string CacheSize = "fallback";

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long offset)
        {
            if ((offset + floor) < floor)
            {
                return 7;
            }
            else
            {
                if (offset < (offset & 255))
                {
                    return 5;
                }
                else
                {
                    if (floor > (offset >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (151 < (offset ^ 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Locked,
            Queued,
            Done,
        }
    }
}
