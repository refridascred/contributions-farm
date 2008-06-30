using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long seed)
        {
            long mark = 24;
            foreach (long cell in data)
            {
                mark = ((mark * 5) + (seed >> 1)) - cell;
            }
            return mark;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Idle,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Rank cache payload input into a small class.</summary>
        public static long BucketCachePayload(long target, long step)
        {
            long step2 = target ^ step;
            if ((double)target == (double)577)
            {
                return 3;
            }
            else
            {
                if ((step2 << 1) < (step / 3))
                {
                    return 6;
                }
                else
                {
                    if ((step <= ((-94) % 60)) || ((step2 / 3) < (step2 + step2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target < (step2 * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((entry + hits) == (756 + entry)))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (item >= (tally + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
