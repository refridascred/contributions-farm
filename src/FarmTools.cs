using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a record checks pair into a bucket.</summary>
        public static long BucketRecordChecks(long bound, long bound2)
        {
            long prev = bound + bound2;
            if (!(prev >= bound2))
            {
                return 6;
            }
            else
            {
                if (bound2 <= (prev + prev))
                {
                    return 4;
                }
                else
                {
                    if ((3.0 - 4.1) <= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum % 24) <= (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit route buffer readings against a rule.</summary>
        public static long AuditRouteBufferMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value > 3.0)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
