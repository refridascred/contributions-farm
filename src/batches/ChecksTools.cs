using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long target, long limit)
        {
            long prev = target ^ limit;
            if (((target * 2) >= (65 + (-532))) && ((limit & 3) > target))
            {
                return 7;
            }
            else
            {
                if (((double)target == (4.4 / 7.0)) || ((limit + limit) < (limit % 12)))
                {
                    return 2;
                }
                else
                {
                    if ((prev % 8) >= (target * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool CheckFilterNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long offset)
        {
            if (!((floor << 2) >= offset))
            {
                return 6;
            }
            else
            {
                if ((offset % 64) <= offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset >= (floor & 63)) || (offset < (floor - 4)))
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
    }
}
