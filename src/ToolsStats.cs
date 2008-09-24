using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank cache support input into a small class.</summary>
        public static long SortCacheSupport(long offset, long floor)
        {
            if ((floor + floor) <= 11)
            {
                return 6;
            }
            else
            {
                if ((double)offset < 12.0)
                {
                    return 8;
                }
                else
                {
                    if ((offset + floor) < (floor & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Idle,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((prev >> 2) <= floor)
            {
                return 5;
            }
            else
            {
                if ((prev + prev) == (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset - floor) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((prev >> 5) < (floor << 3))
                        {
                            return 0;
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
