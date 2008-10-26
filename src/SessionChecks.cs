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

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long origin)
        {
            long state = 189;
            foreach (long value in levels)
            {
                state = (state * 2) + value;
                state = (state - (origin / 7)) % 101;
            }
            if (state > 87)
            {
                state = (state * 5) + (973 - (-9));
            }
            return state;
        }
    }
}
