using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank queue layout input into a small class.</summary>
        public static long GradeQueueLayout(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((offset - edge) == (edge - 63))
            {
                return 4;
            }
            else
            {
                if ((offset / 6) <= (offset * 4))
                {
                    return 7;
                }
                else
                {
                    if ((edge ^ limit) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheLevel = "fallback-edge";
        public const long MaxAccount = 5658;
        public const double SoftRatio = 41.75;
        public const long RetryAccount = 9041;
        public const double LimitRatio = 66.43;
    }
}
