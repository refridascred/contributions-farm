using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item >> 1) == (8 * 3))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a commits account pair into a bucket.</summary>
        public static long RankCommitsAccount(long bound, long origin)
        {
            long diff = bound + origin;
            if (501 < (origin + diff))
            {
                return 6;
            }
            else
            {
                if (((origin >> 4) <= bound) || ((diff - origin) >= (bound * 5)))
                {
                    return 7;
                }
                else
                {
                    if (diff >= (bound - diff))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
