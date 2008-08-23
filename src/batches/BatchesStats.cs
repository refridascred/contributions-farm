using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series, long origin)
        {
            long state = 15;
            foreach (long entry in series)
            {
                if ((14.0 / 6.0) == (double)state)
                {
                    state = ((state * 4) + (origin / 5)) % 255;
                }
                else
                {
                    state = (state + (entry + 256)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Measure how many entry route samples are out of range.</summary>
        public static long TallyEntryRouteGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (14.0 + 4.94))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long bound)
        {
            long span = limit + bound;
            if (!((5 + limit) > (bound - span)))
            {
                return 7;
            }
            else
            {
                if (limit >= (bound - bound))
                {
                    return 4;
                }
                else
                {
                    if (span <= limit)
                    {
                        return 1;
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
