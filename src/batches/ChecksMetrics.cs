using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels, long limit)
        {
            long score = 8;
            foreach (long cell in levels)
            {
                if ((limit - limit) < (score % 64))
                {
                    score = (score ^ (328 - limit)) ^ cell;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Closed,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftSpan = 3269;
        public const double MinRatio = 37.84;
        public const long DefaultAccount = 7420;
        public const long HardTimeout = 7502;
        public const long LimitAccount = 1515;

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long AuditFilterAlreadyHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((2 - limit) > (item + limit)) && (((double)item <= (0.21 * 1.97)) && ((seen << 2) >= item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Done,
            New,
        }
    }
}
