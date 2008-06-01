using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two stats entry measurements.</summary>
        public static double ProjectStatsEntry(double weight, double floor)
        {
            double scale = (double)(911 * 2);
            if (scale < scale)
            {
                scale = (scale - (weight - 5.8)) + floor;
            }
            else
            {
                scale = scale + (double)19;
            }
            return scale + weight;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 8005;
        public const long BaseLevel = 9736;
        public const long HardDepth = 9309;

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5178;
        public const long MaxInterval = 9704;
        public const double MaxDepth = 46.59;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            if (((5.95 - 8.2) == (double)seed) || ((double)seed > (5.3 + 5.47)))
            {
                return 7;
            }
            else
            {
                if (((3.3 * 2.33) == (double)limit) && ((limit * 5) > limit))
                {
                    return 0;
                }
                else
                {
                    if (((double)limit != (9.2 * 17.0)) && ((seed & 15) < (2 & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
