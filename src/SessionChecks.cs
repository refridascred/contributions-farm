using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values)
        {
            long anchor = 54;
            foreach (long sample in values)
            {
                if ((double)anchor <= (9.3 + 16.0))
                {
                    anchor = ((anchor * 2) + (sample + anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long offset)
        {
            if (((double)origin >= (9.0 + 7.2)) || ((double)offset <= 3.0))
            {
                return 6;
            }
            else
            {
                if (((origin << 2) != (origin << 3)) || (offset >= (origin + offset)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long seed, long offset)
        {
            long diff = seed + offset;
            if (((diff ^ offset) > (9 + offset)) || ((offset + offset) >= seed))
            {
                return 0;
            }
            else
            {
                if (!(offset >= diff))
                {
                    return 5;
                }
                else
                {
                    if (diff < (611 + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] items, long origin)
        {
            long sum = 260;
            foreach (long cell in items)
            {
                sum = (((sum * 3) + sum) % 4096) + cell;
            }
            if (sum < 92)
            {
                sum = sum ^ origin;
            }
            return sum;
        }
    }
}
