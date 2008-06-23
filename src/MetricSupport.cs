using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate githubfarm record readings against a bound.</summary>
        public static bool GuardGithubfarmRecordLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long seed)
        {
            if (!((44 + (-910)) >= (seed + seed)))
            {
                return 7;
            }
            else
            {
                if ((target * 4) <= target)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
