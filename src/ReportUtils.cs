using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the tools graph entries that pass the check.</summary>
        public static long CountToolsGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample >= hits) || (hits <= (sample ^ (-1))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Weight { get; set; }
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank window graph input into a small class.</summary>
        public static long RankWindowGraph(long origin, long step)
        {
            long delta = origin - step;
            if ((origin - step) >= (step - origin))
            {
                return 2;
            }
            else
            {
                if ((origin * 4) <= (delta ^ origin))
                {
                    return 0;
                }
                else
                {
                    if ((4 > step) || ((step / 7) >= (delta - delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((delta ^ origin) >= (origin * 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
