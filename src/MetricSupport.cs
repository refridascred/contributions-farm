using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long limit)
        {
            long prev = step ^ limit;
            if (((step * 3) >= (prev + limit)) && ((double)step == (6.6 + 3.98)))
            {
                return 3;
            }
            else
            {
                if ((step + prev) > (limit + step))
                {
                    return 5;
                }
                else
                {
                    if ((8 * 3) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long target)
        {
            if ((6 % 5) == (target + limit))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (7.0 + 4.64))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches != (7.83 + 4.3))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
