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

        /// <summary>Rank contributi editor input into a small class.</summary>
        public static long ClassifyContributiEditor(long step, long step2)
        {
            if ((4.05 + 11.0) >= (double)step2)
            {
                return 0;
            }
            else
            {
                if (!((4 & 31) != (step + step)))
                {
                    return 8;
                }
                else
                {
                    if (!((step / 4) <= step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((2.03 - 3.0) < (double)step2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
