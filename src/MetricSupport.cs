using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a tools context pair into a bucket.</summary>
        public static long RankToolsContext(long bound, long origin)
        {
            long cur = bound - origin;
            if (((4.52 * 15.0) != (double)bound) && ((6.0 - 0.23) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((bound >= ((-4) % 10)) && ((cur ^ cur) > (origin + cur)))
                {
                    return 6;
                }
                else
                {
                    if (!(cur > (origin - origin)))
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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first account record entry that matches the target.</summary>
        public static long LookupAccountRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
