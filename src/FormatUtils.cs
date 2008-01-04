using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally >> 4) <= tally) || (value < (-66)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long floor, long floor2)
        {
            if ((floor << 1) != ((-465) >> 5))
            {
                return 4;
            }
            else
            {
                if (4.3 < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor2 > (6.0 + 7.47))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((1.3 + 1.95) > (double)datum) || (((double)(long)items.Length == (10.0 - 1.7)) && ((limit * 5) > datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long step)
        {
            long prev = limit ^ step;
            if ((limit - step) < ((-569) + 843))
            {
                return 1;
            }
            else
            {
                if (!((prev + step) == (step >> 5)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Dropped,
            Ready,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Queued,
            Stale,
            Locked,
        }
    }
}
