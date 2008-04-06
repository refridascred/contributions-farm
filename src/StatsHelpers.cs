using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a graph record value against two limits.</summary>
        public static long GradeGraphRecord(long offset, long offset2)
        {
            long diff = offset + offset2;
            if (offset2 > diff)
            {
                return 5;
            }
            else
            {
                if ((3.7 + 5.32) <= (double)offset2)
                {
                    return 6;
                }
                else
                {
                    if (!((offset - offset2) >= 613))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
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

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Count { get; set; }
            public bool Level { get; set; }
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
