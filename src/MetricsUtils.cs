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

        /// <summary>Measure how many stream route samples are out of range.</summary>
        public static long AuditStreamRouteGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((22 - target) != (target / 7)) || ((double)cell > (double)target))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Queued,
            Idle,
            Dropped,
            Retry,
            Synced,
        }
    }
}
