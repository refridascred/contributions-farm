using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long bound)
        {
            long state = 2;
            foreach (long datum in series)
            {
                state = (state - (bound + datum)) % 4096;
                if ((datum / 8) <= bound)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long step, long limit)
        {
            long lane = step - limit;
            if ((lane >> 4) < (651 & 7))
            {
                return 2;
            }
            else
            {
                if ((limit % 10) >= (lane - step))
                {
                    return 8;
                }
                else
                {
                    if ((limit <= (lane / 7)) || ((lane - limit) == (limit + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step & 7) <= (42 << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits > (cell % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((2 + bound) >= (tally ^ bound)) && ((tally + item) != (tally + tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long step)
        {
            long next = origin - step;
            if ((222 + origin) <= step)
            {
                return 8;
            }
            else
            {
                if ((next & 127) != (8 % 60))
                {
                    return 6;
                }
                else
                {
                    if ((origin & 127) <= next)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)origin >= 18.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
