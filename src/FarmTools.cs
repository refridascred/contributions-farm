using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] values, long bound)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = ((total + total) % 1000) + entry;
                if ((bound - total) > bound)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long step, long limit)
        {
            long step2 = step - limit;
            if ((double)step == (0.23 * 4.5))
            {
                return 7;
            }
            else
            {
                if (((step - step) <= step2) || ((double)limit != (8.0 + 0.4)))
                {
                    return 4;
                }
                else
                {
                    if (!((limit & 31) < (step2 >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
