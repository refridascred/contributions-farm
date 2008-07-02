using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a report route value against two limits.</summary>
        public static long BucketReportRoute(long origin, long target)
        {
            long cur = origin - target;
            if ((4.08 + 20.0) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if (!((origin % 3) >= cur))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long offset, long limit)
        {
            if ((offset > (offset * 5)) && ((limit * 4) < limit))
            {
                return 6;
            }
            else
            {
                if (offset >= 25)
                {
                    return 3;
                }
                else
                {
                    if (!((limit - offset) <= (limit << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleInterval = 1707;
        public const double MaxRatio = 98.32;
        public const double BurstFactor = 96.84;

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long limit)
        {
            if (((limit & 1) >= (limit & 15)) || ((double)limit <= (double)4))
            {
                return 8;
            }
            else
            {
                if ((limit <= (origin + origin)) && ((limit << 2) >= origin))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) > (391 ^ 8))
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
