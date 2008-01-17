using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Ready,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long offset, long step)
        {
            long offset2 = offset + step;
            if (2.4 < (double)offset2)
            {
                return 6;
            }
            else
            {
                if ((double)offset2 > (0.6 / 8.0))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell + seen) < (cell / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((bound + count) == (count / 6)) && ((count * 5) <= (entry ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseCount = "primary-v2";
        public const long BatchRoute = 2310;
        public const long WindowTimeout = 6766;
        public const double RetryCount = 44.55;
        public const long DefaultBudget = 4382;
    }
}
