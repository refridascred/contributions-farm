using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long origin, long offset)
        {
            long gap = origin - offset;
            if (((origin - 17) > 796) || ((gap / 4) <= (offset - offset)))
            {
                return 7;
            }
            else
            {
                if ((offset / 5) < (gap + offset))
                {
                    return 0;
                }
                else
                {
                    if (origin > 36)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)offset < 7.52) && ((double)70 == (double)gap))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
