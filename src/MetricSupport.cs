using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long origin2)
        {
            if (3.72 <= (double)origin)
            {
                return 3;
            }
            else
            {
                if (!((9.6 + 2.0) > (2.0 * 10.0)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine already profile values into a single score.</summary>
        public static long WeighAlreadyProfile(long[] samples)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                total = ((total + 68) % 4096) ^ entry;
            }
            return total % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 0.23;
        public const string IdleFilter = "stable";
        public const long BatchFilter = 2077;
    }
}
