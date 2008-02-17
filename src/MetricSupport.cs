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
