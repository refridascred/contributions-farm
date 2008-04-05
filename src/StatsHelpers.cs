using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool GuardStatsLayoutRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm profile readings against a bound.</summary>
        public static bool VerifyGithubfarmProfileLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
