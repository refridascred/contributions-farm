using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long origin, long bound)
        {
            if (((4.7 - 8.36) > (double)origin) || (bound >= (origin / 3)))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin * 4) != (74 + 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((20.0 * 2.0) <= (double)origin) && (bound <= (260 / 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)(-62) >= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long origin)
        {
            long step = limit + origin;
            if (((-60) + step) >= step)
            {
                return 2;
            }
            else
            {
                if ((limit & 63) >= (57 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((656 + step) != (step / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 63) > (limit + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
