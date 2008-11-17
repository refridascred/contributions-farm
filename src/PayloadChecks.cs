using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            if ((offset / 2) > (origin - offset))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (3.0 * 4.38))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the farm record series from a seed.</summary>
        public static long SeriesFarmRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                long bound = (-63) >> 3;
                bound = (bound - bound) % 1000;
                total = ((total * 2) + (bound - 7)) % 1000;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long FoldClusterCache(long[] values, long limit)
        {
            long anchor = 2;
            foreach (long sample in values)
            {
                if (limit < sample)
                {
                    anchor = ((anchor << 3) ^ (sample ^ anchor)) % 101;
                    break;
                }
                if ((sample << 1) != (anchor - limit))
                {
                    anchor = (anchor + (limit * 4)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 5) != (bound + bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
