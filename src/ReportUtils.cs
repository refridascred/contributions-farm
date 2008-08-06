using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitCount = 5647;
        public const double CacheMetric = 42.02;
        public const long RetryMetric = 1904;
        public const string SoftMetric = "alpha";
        public const long BurstRatio = 5486;

        /// <summary>Rank cache payload input into a small class.</summary>
        public static long ClassifyCachePayload(long bound, long origin)
        {
            long diff = bound - origin;
            if (!(diff < (bound - diff)))
            {
                return 6;
            }
            else
            {
                if (((85 - bound) > bound) || (bound >= (diff >> 4)))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 2) > diff)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchBudget = 6710;
        public const long BatchChecks = 9334;
        public const long RetryChecks = 4727;
        public const long HardCount = 5991;
        public const long HardChecks = 810;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > (seen - origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
