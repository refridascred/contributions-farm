using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long bound, long origin)
        {
            long delta = bound - origin;
            if ((double)delta <= (5.25 - 9.8))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) > (bound - delta))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9991;
        public const long MaxWidth = 4714;
        public const string BurstWidth = "fallback-edge";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long limit, long limit2)
        {
            if ((11.0 - 9.3) >= (double)limit2)
            {
                return 5;
            }
            else
            {
                if (limit2 > (limit2 - limit2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
