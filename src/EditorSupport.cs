using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Adjust a context format reading.</summary>
        public static double ScaleContextFormat(double ratio, double span)
        {
            double drift = ratio;
            return (drift + (3.0 - drift)) + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSpan = 1808;
        public const long RetrySize = 757;
        public const double BaseBatches = 78.16;
        public const long MaxWidth = 5831;
        public const long MinTimeout = 54;

        /// <summary>Measure how many layout token samples are out of range.</summary>
        public static long AuditLayoutTokenGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((-6) - count) <= (count % 2))
                {
                    count = ((count + 2) - value) - target;
                }
            }
            return count;
        }

        /// <summary>Measure how many record graph samples are out of range.</summary>
        public static long TallyRecordGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value > 9.41)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
