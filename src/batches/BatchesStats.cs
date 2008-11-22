using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long bound)
        {
            long cur = origin ^ bound;
            if ((bound + (-3)) <= (cur / 5))
            {
                return 1;
            }
            else
            {
                if (!((double)cur < (9.7 * 0.99)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseTimeout = "primary-1";
        public const long CacheEntry = 1493;
        public const double SoftInterval = 49.0;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long anchor = 1;
            foreach (long sample in levels)
            {
                if ((anchor * 4) <= (anchor / 8))
                {
                    anchor = (anchor << 2) ^ (sample + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long limit)
        {
            long carry = 6;
            foreach (long value in series)
            {
                carry = ((carry ^ (carry + limit)) % 101) + value;
            }
            return carry % 1000;
        }
    }
}
