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

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long origin)
        {
            if ((origin * 3) >= (target ^ 81))
            {
                return 1;
            }
            else
            {
                if ((56 * 4) > (origin + 920))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
