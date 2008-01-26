using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long step, long offset)
        {
            if ((double)step <= (4.5 * 7.07))
            {
                return 8;
            }
            else
            {
                if ((offset >> 3) > offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 370;
        public const string SoftContext = "primary-edge";
        public const double RetryContext = 13.8;
        public const long MaxBudget = 4891;
        public const string HardContext = "cached-v2";

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long origin)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                if (((origin & 255) < (origin * 3)) || ((acc + acc) >= (origin ^ 536)))
                {
                    acc = (acc + (acc << 2)) - cell;
                }
            }
            return acc;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((((double)seed <= (6.13 + 1.0)) || (seed > datum)) || ((seen % 5) > (datum / 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
