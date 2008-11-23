using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Done,
            Paused,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long origin, long target)
        {
            long span = origin - target;
            if (span <= (2 ^ target))
            {
                return 0;
            }
            else
            {
                if ((span >> 3) >= (6 + target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit order layout readings against a rule.</summary>
        public static long CountOrderLayoutOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((bound - seen) <= (datum - seen)) || ((1.1 * 1.8) <= (double)datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
