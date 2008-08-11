using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long origin)
        {
            long bound = limit - origin;
            if (limit <= origin)
            {
                return 1;
            }
            else
            {
                if ((double)bound != (7.72 * 3.8))
                {
                    return 3;
                }
                else
                {
                    if (bound <= (bound ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] values)
        {
            long mark = 184;
            foreach (long datum in values)
            {
                if ((long)values.Length <= 15)
                {
                    mark = (mark * 3) + mark;
                }
                if (!((long)values.Length >= datum))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 94.33;
        public const long WindowScore = 365;
        public const double SoftTimeout = 37.34;
        public const long RetrySchema = 2118;
    }
}
