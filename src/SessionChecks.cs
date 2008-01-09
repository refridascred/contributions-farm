using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long origin)
        {
            long prev = offset - origin;
            if (!(origin < (prev + prev)))
            {
                return 1;
            }
            else
            {
                if (!((prev * 2) < offset))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Locked,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Measure how many stats window samples are out of range.</summary>
        public static long TallyStatsWindowHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((double)count == (4.88 + 9.5)))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long target, long limit)
        {
            if (target < (limit << 3))
            {
                return 2;
            }
            else
            {
                if (target > (target + 13))
                {
                    return 4;
                }
                else
                {
                    if ((2 >> 4) > target)
                    {
                        return 0;
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
