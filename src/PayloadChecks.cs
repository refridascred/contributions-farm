using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((8.5 - 3.1) > (double)floor)
                {
                    anchor = ((anchor * 4) + (floor * 5)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every report command entry stays within the limit.</summary>
        public static bool CheckReportCommandLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long floor)
        {
            if ((floor << 1) == (bound / 2))
            {
                return 2;
            }
            else
            {
                if ((floor + bound) > bound)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((6.2 * 18.0) == (double)count)
                {
                    count = ((count + 2) + datum) - limit;
                }
            }
            return count;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long limit, long target)
        {
            if ((target >> 3) > (target + target))
            {
                return 3;
            }
            else
            {
                if (((8.3 / 4.0) == (double)target) && (limit < 4))
                {
                    return 4;
                }
                else
                {
                    if ((target & 3) < limit)
                    {
                        return 2;
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
