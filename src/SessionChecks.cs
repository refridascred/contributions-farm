using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric graph samples.</summary>
        public static long WeighMetricGraph(long[] values)
        {
            long score = 59;
            foreach (long cell in values)
            {
                score = (score - (score % 12)) ^ cell;
            }
            if (score < 514)
            {
                score = (score + (score * 5)) % 1000;
            }
            return score;
        }

        /// <summary>Validate layout token readings against a bound.</summary>
        public static bool GuardLayoutTokenRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
