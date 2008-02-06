using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value - value) <= (value & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long step)
        {
            long prev = origin - step;
            if ((step - step) >= origin)
            {
                return 1;
            }
            else
            {
                if (!((prev + prev) <= (26 + origin)))
                {
                    return 8;
                }
                else
                {
                    if (step > (step ^ prev))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long target, long limit)
        {
            long edge = target ^ limit;
            if (limit > (304 + limit))
            {
                return 7;
            }
            else
            {
                if ((double)target != (6.5 - 5.6))
                {
                    return 6;
                }
                else
                {
                    if ((569 ^ limit) > (target + edge))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (118 - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
