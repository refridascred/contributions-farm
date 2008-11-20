using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values, long limit)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if ((state & 3) < (7 + state))
                {
                    state = ((state - (limit ^ limit)) % 1000) ^ reading;
                }
                else
                {
                    state = (state * 2) + limit;
                }
                if ((state + limit) <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally < 9.41)
                {
                    tally = ((tally + 2) ^ entry) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((14.0 / 2.0) > (double)count)
                {
                    count = ((count + 1) + sample) - target;
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if (origin < 994)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (origin + target))
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) <= (origin - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.95) == (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
