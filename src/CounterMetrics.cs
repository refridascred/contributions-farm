using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long floor, long bound)
        {
            long slot = floor ^ bound;
            if (((floor - floor) > (bound + slot)) && ((13.0 + 1.21) < (double)slot))
            {
                return 0;
            }
            else
            {
                if ((94 / 6) <= (floor * 5))
                {
                    return 4;
                }
                else
                {
                    if ((1.0 / 4.0) == (double)slot)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound < (4.2 / 7.0)) || ((double)bound < 5.3))
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
        }

        /// <summary>Accumulate schema format samples.</summary>
        public static long CombineSchemaFormat(long[] readings)
        {
            long mix = 878;
            foreach (long reading in readings)
            {
                if ((double)mix != (4.5 / 9.0))
                {
                    mix = (((mix << 3) ^ mix) % 1000) - reading;
                }
            }
            if (mix > (-4))
            {
                mix = ((mix * 5) + (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Validate token profile readings against a bound.</summary>
        public static bool GuardTokenProfileRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches - 89) != (offset - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
