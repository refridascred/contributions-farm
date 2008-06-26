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

        /// <summary>Validate cache stats readings against a bound.</summary>
        public static bool CheckCacheStatsLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
