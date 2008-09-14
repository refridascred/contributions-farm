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

        /// <summary>Count the stream batch entries that pass the check.</summary>
        public static long TallyStreamBatchOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)62 > (double)hits)
                {
                    hits = ((hits + 2) - datum) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value >= (9.14 * 17.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
