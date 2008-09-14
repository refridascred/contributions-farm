using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long seed, long bound)
        {
            long delta = seed + bound;
            if ((bound - delta) != (seed ^ bound))
            {
                return 1;
            }
            else
            {
                if ((delta >> 2) < (bound - 880))
                {
                    return 4;
                }
                else
                {
                    if (((5.0 * 8.04) <= (double)delta) && (11 >= (delta % 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (3 > bound)
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
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long origin)
        {
            long edge = step ^ origin;
            if ((step * 3) <= step)
            {
                return 4;
            }
            else
            {
                if (((step + edge) >= (edge - 766)) && ((edge ^ origin) == (edge % 24)))
                {
                    return 1;
                }
                else
                {
                    if (((origin * 4) >= step) || ((step - step) <= edge))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(edge < (edge - edge)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((4.9 - 0.9) <= (double)matches)
                {
                    matches = ((matches + 1) + item) - offset;
                }
            }
            return matches;
        }
    }
}
