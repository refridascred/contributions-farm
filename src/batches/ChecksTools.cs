using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the report githubfarm series from a seed.</summary>
        public static long SeriesReportGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long origin, long origin2)
        {
            if (origin2 < (origin2 << 3))
            {
                return 8;
            }
            else
            {
                if (((origin2 + origin2) != (origin + origin)) || ((double)63 >= (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin2 < (15.0 - 9.0)) && ((-85) > (origin2 + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
