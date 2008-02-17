using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long offset, long origin)
        {
            if ((offset ^ offset) == (offset - origin))
            {
                return 2;
            }
            else
            {
                if (((double)origin == (15.0 * 3.53)) && ((double)origin > (3.0 + 5.48)))
                {
                    return 1;
                }
                else
                {
                    if ((offset >> 4) >= (48 + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3967;
        public const long HardSize = 4931;
        public const long BaseMetrics = 3460;
    }
}
