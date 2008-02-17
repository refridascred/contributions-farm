using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long origin)
        {
            long gap = limit - origin;
            if (origin <= (origin % 7))
            {
                return 2;
            }
            else
            {
                if (limit > (7 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((limit * 5) >= (origin / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + origin) != (gap - 99))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchCount = 115;
        public const long BatchProfile = 3221;
        public const double BatchFactor = 59.57;
        public const double LimitProfile = 23.74;
        public const double SoftProfile = 61.28;
    }
}
