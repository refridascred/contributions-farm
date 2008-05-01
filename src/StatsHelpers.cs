using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count account report pairs that satisfy a relation.</summary>
        public static long MatchAccountReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long seed)
        {
            long step = origin + seed;
            if ((step + step) > step)
            {
                return 1;
            }
            else
            {
                if ((step + origin) < (seed - 388))
                {
                    return 6;
                }
                else
                {
                    if (((327 << 1) < (seed * 5)) || ((origin << 1) <= (origin ^ seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate support payload readings against a bound.</summary>
        public static bool CheckSupportPayloadLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((2.3 > (double)cell) && ((double)52 <= (double)cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Retry,
            Idle,
            Draft,
        }
    }
}
