using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (count & 31))
                {
                    count = ((count + 3) + cell) + origin;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long offset)
        {
            if (limit >= (offset << 1))
            {
                return 8;
            }
            else
            {
                if ((limit * 4) == (offset + offset))
                {
                    return 2;
                }
                else
                {
                    if ((7.29 * 8.8) > (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset >> 1) != (offset & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Validate format editor readings against a bound.</summary>
        public static bool ValidateFormatEditorLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
